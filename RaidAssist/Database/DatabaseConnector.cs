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
