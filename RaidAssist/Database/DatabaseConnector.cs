using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RaidAssist.Data;

namespace RaidAssist.Database
{
    public class DatabaseConnector
    {
        private MySqlConnection _connection;
        private string _serverName;
        private string _databaseName;
        private string _userName;
        private string _password;

        public DatabaseConnector(string serverName, string databaseName, string userName, string password)
        {
            _serverName = serverName;
            _databaseName = databaseName;
            _userName = userName;
            _password = password;
        }

        public MySqlConnection Connection { get { return _connection; } }

        public void Init()
        {
            var connectionString = "SERVER=" + _serverName + ";" + "DATABASE=" +
            _databaseName + ";" + "UID=" + _userName + ";" + "PASSWORD=" + _password + ";";

            _connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal bool RenameBotGroup(BotGroup botGroup, string newName)
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                var nameCheckQuery = string.Format("select * from bot_groups where group_name = '{0}';", newName);
                var cmd = new MySqlCommand(nameCheckQuery, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.HasRows)
                        return false;
                }

                var updateQuery = string.Format("update bot_groups set group_name = '{0}' where groups_index = {1};", newName, botGroup.GroupIndex);
                cmd = new MySqlCommand(updateQuery, _connection);
                var result = cmd.ExecuteNonQuery();
                if (result != -1)
                    return true;
            }
            return false;
        }

        internal BotGroup CreateBotGroup(Bot bot, string groupName)
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                var nameCheckQuery = string.Format("select * from bot_groups where group_name = '{0}';", groupName);
                var cmd = new MySqlCommand(nameCheckQuery, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.HasRows)
                        return null;
                }

                var insertQuery = string.Format("insert into bot_groups (group_leader_id, group_name) values ('{0}', '{1}');", bot.Id, groupName);
                cmd = new MySqlCommand(insertQuery, _connection);
                var result = cmd.ExecuteNonQuery();
                if (result == -1)
                    return null;

                
                var botGroup = new BotGroup();

                var groupCheckQuery = string.Format("select * from bot_groups where group_leader_id = '{0}';", bot.Id);
                cmd = new MySqlCommand(groupCheckQuery, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        botGroup = new BotGroup();
                        botGroup.GroupLeaderId = Convert.ToInt32(dataReader["group_leader_id"]);
                        botGroup.GroupName = Convert.ToString(dataReader["group_name"]);
                        botGroup.GroupIndex = Convert.ToInt32(dataReader["groups_index"]);
                        botGroup.LeaderName = bot.Name;
                    }
                }

                insertQuery = string.Format("insert into bot_group_members (groups_index, bot_id) values ('{0}', '{1}');", botGroup.GroupIndex, bot.Id);
                cmd = new MySqlCommand(insertQuery, _connection);
                result = cmd.ExecuteNonQuery();
                if (result == -1)
                    return null;

                return botGroup;
            }

            return null;
        }


        internal List<Character> LoadCharacters(User _user)
        {
            var characters = new List<Character>();
            if(_connection.State == System.Data.ConnectionState.Open)
            {
                var query = string.Format("select * from character_data where account_id = {0};", _user.AccountId);

                var cmd = new MySqlCommand(query, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var character = new Character();
                        character.ClassId = Convert.ToInt32(dataReader["class"]);
                        character.Id = Convert.ToInt32(dataReader["id"]);
                        character.Name = Convert.ToString(dataReader["name"]);
                        characters.Add(character);
                    }
                }
            }

            return characters;
        }

        internal List<Bot> LoadBots(Character selectedCharacter)
        {
            var bots = new List<Bot>();
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                var query = string.Format("select * from bot_data where owner_id = {0};", selectedCharacter.Id);
                var cmd = new MySqlCommand(query, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var bot = new Bot();
                        bot.ClassId = Convert.ToInt32(dataReader["class"]);
                        bot.Id = Convert.ToInt32(dataReader["bot_id"]);
                        bot.Name = Convert.ToString(dataReader["name"]);
                        bots.Add(bot);
                    }
                }

                foreach(var bot in bots)
                {
                    bot.Inventory = new Inventory();
                    bot.Inventory.Items = LoadBotInventory(bot);
                    query = string.Format("select * from bot_group_members where bot_id={0};", bot.Id);
                    cmd = new MySqlCommand(query, _connection);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        while(dataReader.Read())
                        {
                            if(!bot.IsLeader)
                                bot.IsMember = true;
                        }
                    }

                    query = string.Format("select * from bot_heal_rotations where bot_id={0}", bot.Id);
                    cmd = new MySqlCommand(query, _connection);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        while(dataReader.Read())
                        {
                            bot.HealRotationId = Convert.ToInt32(dataReader["heal_rotation_index"]);
                            bot.IsHealRotationLeader = true;
                        }
                    }

                    query = string.Format("select * from bot_heal_rotation_members where bot_id={0}", bot.Id);
                    cmd = new MySqlCommand(query, _connection);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            bot.HealRotationId = Convert.ToInt32(dataReader["heal_rotation_index"]);
                            bot.IsHealRotationMember = true;
                        }
                    }
                }
            }
            return bots;
        }

        internal BotGroup LoadBotGroup(Character bot)
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                var query = string.Format("select * from bot_groups where group_leader_id = {0};", bot.Id);
                var cmd = new MySqlCommand(query, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    if(dataReader.HasRows)
                        while (dataReader.Read())
                        {
                            var botGroup = new BotGroup();
                            botGroup.GroupName = Convert.ToString(dataReader["group_name"]);
                            botGroup.GroupIndex = Convert.ToInt32(dataReader["groups_index"]);
                            botGroup.GroupLeaderId = Convert.ToInt32(dataReader["group_leader_id"]);
                            return botGroup;
                        }
                }
            }

            return null;
        }

        internal HealRotation LoadBotHealRotation(Bot bot)
        {
            var healRotation = new HealRotation();
            if(_connection.State == System.Data.ConnectionState.Open)
            {
                var queryHealRotation = string.Format("select * from bot_heal_rotations where bot_id={0};", bot.Id);
                var cmdRemove = new MySqlCommand(queryHealRotation, _connection);
                using (var dataReader = cmdRemove.ExecuteReader())
                {
                    if (!dataReader.HasRows)
                        return null;
                    while(dataReader.Read())
                    {
                        bot.HealRotationId = Convert.ToInt32(dataReader["heal_rotation_index"]);
                        bot.IsHealRotationLeader = true;
                        bot.IsHealRotationMember = true;

                        healRotation.AdaptiveTargeting = Convert.ToInt32(dataReader["adaptive_targeting"]);
                        healRotation.CastingOverride = Convert.ToInt32(dataReader["casting_override"]);
                        healRotation.CriticalHPBase = Convert.ToSingle(dataReader["critical_hp_base"]);
                        healRotation.CriticalHPChain = Convert.ToSingle(dataReader["critical_hp_chain"]);
                        healRotation.CriticalHPCloth = Convert.ToSingle(dataReader["critical_hp_cloth"]);
                        healRotation.CriticalHPLeather = Convert.ToSingle(dataReader["critical_hp_leather"]);
                        healRotation.CriticalHPPlate = Convert.ToSingle(dataReader["critical_hp_plate"]);
                        healRotation.SafeHPBase = Convert.ToSingle(dataReader["safe_hp_base"]);
                        healRotation.SafeHPCloth = Convert.ToSingle(dataReader["safe_hp_cloth"]);
                        healRotation.SafeHPChain = Convert.ToSingle(dataReader["safe_hp_chain"]);
                        healRotation.SafeHPLeather = Convert.ToSingle(dataReader["safe_hp_leather"]);
                        healRotation.SafeHPPlate = Convert.ToSingle(dataReader["safe_hp_plate"]);
                        healRotation.FastHeals = Convert.ToInt32(dataReader["fast_heals"]);
                        healRotation.Interval = Convert.ToInt32(dataReader["interval"]);
                        healRotation.Id = Convert.ToInt32(dataReader["heal_rotation_index"]);
                        healRotation.BotId = bot.Id;
                    }
                }
                var queryHealRotationMembers = string.Format("select * from bot_heal_rotation_members where heal_rotation_index = {0};", healRotation.Id);
                var cmdMembers = new MySqlCommand(queryHealRotationMembers, _connection);
                using (var memberReader = cmdMembers.ExecuteReader())
                {
                    if (memberReader.HasRows)
                        if (healRotation.Members == null)
                            healRotation.Members = new List<Bot>();
                    while (memberReader.Read())
                    {
                        var member = new Bot();
                        member.HealRotationId = healRotation.Id;
                        member.IsHealRotationMember = true;
                        member.Id = Convert.ToInt32(memberReader["bot_id"]);
                        healRotation.Members.Add(member);
                    }
                }

                var queryHealRotationTargets = string.Format("select * from bot_heal_rotation_targets where heal_rotation_index = {0};", healRotation.Id);
                var cmdTargets = new MySqlCommand(queryHealRotationTargets, _connection);
                using (var targetReader = cmdTargets.ExecuteReader())
                {
                    if (targetReader.HasRows)
                        if (healRotation.Targets == null)
                            healRotation.Targets = new List<Character>();
                    while (targetReader.Read())
                    {
                        var target = new Character();
                        target.Name = Convert.ToString(targetReader["target_name"]);
                        //target.Id = Convert.ToInt32(targetReader["target_index"]); Char or Bot ID will have to be determined later based on name :-(
                        healRotation.Targets.Add(target);
                    }
                }
                return healRotation;
            }
            return null;
        }

        internal bool DeleteBotGroup(BotGroup botGroup, bool lastMember = false)
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                if(lastMember)
                {
                    var queryLeader = string.Format("delete from bot_groups where group_leader_id = {0};", botGroup.GroupLeaderId);
                    var cmdRemove = new MySqlCommand(queryLeader, _connection);
                    var removeResult = cmdRemove.ExecuteNonQuery();
                    if (removeResult != -1)
                        return true;
                }
                var memberQuery = string.Format("delete from bot_group_members where groups_index={0};", botGroup.GroupIndex);
                var cmd = new MySqlCommand(memberQuery, _connection);
                var result = cmd.ExecuteNonQuery();
                if (result != -1)
                {
                    var queryLeader = string.Format("delete from bot_groups where group_leader_id = {0};", botGroup.GroupLeaderId);
                    cmd = new MySqlCommand(queryLeader, _connection);
                    result = cmd.ExecuteNonQuery();
                    if (result != -1)
                        return true;
                }
                else
                    return false;
            }
            return false;
        }

        internal bool AddBotToGroup(Bot bot, BotGroup botGroup)
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                var addQuery = string.Format("insert into bot_group_members (groups_index, bot_id) values ('{0}', '{1}');", botGroup.GroupIndex, bot.Id);
                var cmd = new MySqlCommand(addQuery, _connection);
                var result = cmd.ExecuteNonQuery();
                if(result != -1)
                {
                    if (botGroup.Members == null)
                        botGroup.Members = new List<Bot>();
                    bot.GroupId = botGroup.GroupIndex;
                    bot.IsMember = true;
                    botGroup.Members.Add(bot);

                    return true;
                }
            }
           return false;
        }

        internal bool RemoveBotFromGroup(Bot bot, BotGroup botGroup)
        {
            if(_connection.State == System.Data.ConnectionState.Open)
            {
                var removeQuery = string.Format("delete from bot_group_members where bot_id = {0} and groups_index={1};", bot.Id, botGroup.GroupIndex);
                var cmd = new MySqlCommand(removeQuery, _connection);
                var result = cmd.ExecuteNonQuery();

                if (result == 0)
                    return false;
                if (result != -1 )
                {
                    var botToRemove = botGroup.Members.Single(b => b.Id == bot.Id);
                    botToRemove.IsMember = false;
                    botGroup.Members.Remove(botToRemove);

                    if(botGroup.Members.Count == 0) // this was the last bot and should be the leader, empty bot groups cannot exist, so we delete those as well.
                    {
                        botToRemove.IsLeader = false;
                        var deleteGroup = DeleteBotGroup(botGroup, true);
                        if (deleteGroup)
                            return true;
                    }
                    
                    return true;
                }
            }
            return false;
        }

        internal List<Bot> LoadBotGroupMembers(BotGroup botGroup)
        {
            var botGroupMembers = new List<Bot>();
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                var query = string.Format("select * from bot_group_members where groups_index = {0};", botGroup.GroupIndex) ;
                var cmd = new MySqlCommand(query, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.HasRows)
                        while (dataReader.Read())
                        {
                            var bot = new Bot();
                            bot.Id = Convert.ToInt32(dataReader["bot_id"]);
                            bot.GroupId = Convert.ToInt32(dataReader["groups_index"]);
                            //bot.IsMember = true;
                            botGroupMembers.Add(bot);
                        }
                }

                foreach (var bot in botGroupMembers)
                {
                    query = string.Format("select * from bot_data where bot_id = {0};", bot.Id);
                    cmd = new MySqlCommand(query, _connection);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                            while (dataReader.Read())
                            {
                                bot.Name = Convert.ToString(dataReader["name"]);
                                bot.ClassId = Convert.ToInt32(dataReader["class"]);
                            }
                    }
                }
            }

            return botGroupMembers;
        }

        internal List<InventoryEntry> LoadBotInventory(Bot bot)
        {
            var botInventoryEntries = new List<InventoryEntry>();

            if (_connection.State == System.Data.ConnectionState.Open)
            {
                var query = string.Format(
                    @"select bot_inventories.item_id, bot_inventories.inventories_index, bot_inventories.bot_id, bot_inventories.slot_id, items.Name
                        from bot_inventories
                        inner join items on items.id = bot_inventories.item_id
                        where bot_inventories.bot_id = {0}; ", bot.Id);
                var cmd = new MySqlCommand(query, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    if (dataReader.HasRows)
                        while (dataReader.Read())
                        {
                            var inventoryEntry = new InventoryEntry();

                            inventoryEntry.Id = Convert.ToInt32(dataReader["inventories_index"]);
                            inventoryEntry.BotId = Convert.ToInt32(dataReader["bot_id"]);
                            inventoryEntry.ItemId = Convert.ToInt32(dataReader["item_id"]);
                            inventoryEntry.SlotId = Convert.ToInt32(dataReader["slot_id"]);
                            inventoryEntry.ItemName = dataReader["Name"].ToString();

                            botInventoryEntries.Add(inventoryEntry);
                        }
                }
            }

            return botInventoryEntries;
        }

        internal User LogIn(User _user, bool localLogin)
        {
            if(_connection.State == System.Data.ConnectionState.Open)
            {
                var query = string.Empty;
                if (localLogin)
                    query = string.Format("select * from loginserver_server_accounts where AccountName = '{0}' and AccountPassword = '{1}';", _user.UserName, _user.Password);
                else
                    query = string.Format("select * from account where name = '{0}' and password = '{1}';", _user.UserName, _user.Password); 

                var cmd = new MySqlCommand(query, _connection);
                var accountFound = false;
                using (var dataReader = cmd.ExecuteReader())
                {
                    if(dataReader.HasRows)  // We found our record, we can proceed.
                    {
                        accountFound = true;
                        if (!localLogin)
                            _user.AccountId = Convert.ToInt32(dataReader["id"]);
                    }
                }

                if(accountFound && localLogin)
                {
                    var accountQuery = string.Format("select * from account where name = '{0}'", _user.UserName);
                    cmd = new MySqlCommand(accountQuery, _connection);
                    using (var dataReader = cmd.ExecuteReader())
                    {
                        while(dataReader.Read())
                        {
                            _user.AccountId = Convert.ToInt32(dataReader["id"]);
                        }
                    }
                }
            }

            return _user;
        }


        //Close connection
        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
