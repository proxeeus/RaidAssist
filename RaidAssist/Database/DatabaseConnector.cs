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

                var groupCheckQuery = string.Format("select * from bot_groups where group_leader_id = '{0}';", bot.Id);
                cmd = new MySqlCommand(groupCheckQuery, _connection);
                using (var dataReader = cmd.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        var botGroup = new BotGroup();
                        botGroup.GroupLeaderId = Convert.ToInt32(dataReader["group_leader_id"]);
                        botGroup.GroupName = Convert.ToString(dataReader["group_name"]);
                        botGroup.GroupIndex = Convert.ToInt32(dataReader["groups_index"]);
                        botGroup.LeaderName = bot.Name;
                        return botGroup;
                    }
                }
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

        internal bool DeleteBotGroup(BotGroup botGroup)
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
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
