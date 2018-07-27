using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RaidAssist.Data;
using RaidAssist.Database;

namespace RaidAssist
{
    public partial class MainForm : Form
    {
        private User _user = new User();
        private DatabaseConnector _connector = new DatabaseConnector("localhost", "proxeeus_db", "root", "eqemu");

        public MainForm()
        {
            InitializeComponent();
            Application.ApplicationExit += Application_ApplicationExit;
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            CloseConnection();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if(loginTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
            {
                BaseLogin();

            }
        }

        private void BaseLogin()
        {
            _user.UserName = loginTextBox.Text;
            var md5Password = Utils.Crypto.GetSHA1(passwordTextBox.Text);
            _user.Password = md5Password;

            _connector.Init();
            try
            {
                if (_connector.OpenConnection())
                {
                    // 1. Log the user in
                    _user = _connector.LogIn(_user, localCheckBox.Checked);

                    // 2. Gets a list of all his characters
                    if (_user.AccountId != -1)
                    {
                        _user.Characters = _connector.LoadCharacters(_user);
                        // 3. Dynamically bind the character list to the combobox for event-driven updates.
                        if (_user.Characters.Count > 0)
                        {
                            characterComboBox.DataSource = _user.Characters;
                            characterComboBox.DisplayMember = "DisplayName";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void characterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newSelectedCharacter = ((ComboBox)sender).SelectedItem as Character;
            _user.SelectedCharacter = newSelectedCharacter;

            LoadBots(_user.SelectedCharacter);
        }

        private void LoadBots(Character selectedCharacter)
        {
            selectedCharacter.Bots = _connector.LoadBots(selectedCharacter);
            if(selectedCharacter.Bots.Count > 0)
            {
                botsListBox.DataSource = selectedCharacter.Bots;
                botsListBox.DisplayMember = "DisplayName";
            }
        }

        private void closeConnectionButton_Click(object sender, EventArgs e)
        {
            CloseConnection();
        }

        private void CloseConnection()
        {
            if (_connector.Connection != null && _connector.Connection.State == ConnectionState.Open)
                _connector.CloseConnection();
        }
    }
}
