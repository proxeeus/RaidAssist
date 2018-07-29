﻿using System;
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

namespace RaidAssist.GUI
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

        private void botGroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newSelectedBotGroup = ((ComboBox)sender).SelectedItem as BotGroup;
            _user.SelectedBotGroup = newSelectedBotGroup;

            LoadBotGroupMembers(_user.SelectedBotGroup);

            if (_user.SelectedBotGroup != null && _user.SelectedBotGroup.Members != null && _user.SelectedBotGroup.Members.Count > 0)
            {
                botGroupMembersListBox.DataSource = _user.SelectedBotGroup.Members;
                botGroupMembersListBox.DisplayMember = "DisplayName";
            }
            else if(_user.SelectedBotGroup != null && (_user.SelectedBotGroup.Members != null || _user.SelectedBotGroup.Members.Count == 0))
            {
                botGroupMembersListBox.DataSource = null;
            }
        }

        private void characterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newSelectedCharacter = ((ComboBox)sender).SelectedItem as Character;
            _user.SelectedCharacter = newSelectedCharacter;

            botGroupsComboBox.DataSource = null;
            botGroupsComboBox.DisplayMember = null;
            botsListBox.DataSource = null;
            botsListBox.DisplayMember = null;
            botGroupMembersListBox.DataSource = null;
            botGroupMembersListBox.DisplayMember = null;

            LoadBots(_user.SelectedCharacter);
            LoatBotGroups(_user.SelectedCharacter); // Based on all bots IDs, will return a list of Groups led by one bot
            RefreshUI();
        }


        private void botsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newSelectedBot = ((ListBox)sender).SelectedItem as Bot;
            _user.SelectedBot = newSelectedBot;
        }

        private void RefreshUI()
        {
            if (_user.SelectedCharacter.Bots != null && _user.SelectedCharacter.Bots.Count > 0)
            {
                botsListBox.DataSource = null;
                botsListBox.DisplayMember = null;
                botsListBox.DataSource = _user.SelectedCharacter.Bots;
                botsListBox.DisplayMember = "DisplayName";
            }
            if (_user.SelectedCharacter.BotGroups != null && _user.SelectedCharacter.BotGroups.Count > 0)
            {
                botGroupsComboBox.DataSource = null;
                botGroupsComboBox.DisplayMember = null;
                _user.SelectedCharacter.BotGroups = _user.SelectedCharacter.BotGroups.Where(w => w != null).Distinct().ToList();
                botGroupsComboBox.DataSource = _user.SelectedCharacter.BotGroups;
                botGroupsComboBox.DisplayMember = "DisplayName";
            }     

        }

        private void LoatBotGroups(Character selectedCharacter)
        {
            if (selectedCharacter.Bots.Count > 0)
            {
                selectedCharacter.BotGroups = new List<BotGroup>();
                foreach (var bot in selectedCharacter.Bots)
                {
                    var botGroup = _connector.LoadBotGroup(bot);
                    if (botGroup != null)
                    {
                        botGroup.LeaderName = Utils.Helpers.GetLeaderName(botGroup.GroupLeaderId, selectedCharacter.Bots);
                        selectedCharacter.BotGroups.Add(botGroup);
                    }
                }
            }
        }


        private void LoadBotGroupMembers(BotGroup botGroup)
        {
            if (botGroup != null)
                botGroup.Members = _connector.LoadBotGroupMembers(botGroup);

        }

        private void LoadBots(Character selectedCharacter)
        {
            selectedCharacter.Bots = _connector.LoadBots(selectedCharacter);

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

        private void renameGroupButton_Click(object sender, EventArgs e)
        {
            if (_user.SelectedBotGroup != null)
            {
                var renameForm = new RenameBotGroupForm(_user.SelectedBotGroup, _connector);
                var dialogResult = renameForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    RefreshUI();
            }
            else
                MessageBox.Show("You need to select a Bot Group to rename.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            if(_user.SelectedBot != null)
            {
                if (_user.SelectedBot.IsLeader || _user.SelectedBot.IsMember)
                {
                    MessageBox.Show(string.Format("{0} is already a member of a Bot Group.", _user.SelectedBot.Name), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var createForm = new CreateBotGroupForm(_user.SelectedCharacter,_user.SelectedBot, _connector);
                var dialogResult = createForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    botGroupMembersListBox.DataSource = createForm.NewGroup.Members;
                    botGroupMembersListBox.DisplayMember = "DisplayName";
                    RefreshUI();
                }
            }
            else
                MessageBox.Show("You need to select a valid Bot to act as Group Leader.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            if(_user.SelectedBotGroup != null)
            {
                var dialogResult = MessageBox.Show("Are you sure you want to delete this Bot Group? This CANNOT be undone!", "Confirm deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.OK)
                {
                    var groupDeleted = _connector.DeleteBotGroup(_user.SelectedBotGroup);
                    if(groupDeleted)
                    {
                        _user.SelectedCharacter.BotGroups.Remove(_user.SelectedBotGroup);
                        // Need to update all member status (no leader / member tag)
                        if(_user.SelectedBotGroup.Members != null && _user.SelectedBotGroup.Members.Count >0)
                            foreach(var bot in _user.SelectedBotGroup.Members)
                            {
                                var botToModify = (from b in _user.SelectedCharacter.Bots where bot.Id == b.Id select b).FirstOrDefault();
                                botToModify.IsLeader = false;
                                botToModify.IsMember = false;
                                bot.IsLeader = false;
                                bot.IsMember = false;
                            }
                        RefreshUI();
                    }
                    else
                        MessageBox.Show("Couldn't delete Bot Group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("You need to select a Group Bot to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void botRemoveFromGroup_Click(object sender, EventArgs e)
        {

        }

        private void botGroupMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var intermediateBot = ((ListBox)sender).SelectedItem as Bot;
            if (intermediateBot != null)
            {
                var realSelectedBot = (from b in _user.SelectedCharacter.Bots where intermediateBot.Id == b.Id select b).FirstOrDefault();

                _user.SelectedBot = realSelectedBot;
            }

            if(_user.SelectedBot != null)
                this.Text = string.Format("EQEmu Raid Assist - [{0}] - [{1}] - [{2}]", _user.UserName, _user.SelectedCharacter.Name, _user.SelectedBot.Name);
        }
    }
}
