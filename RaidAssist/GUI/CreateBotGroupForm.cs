using RaidAssist.Data;
using RaidAssist.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaidAssist.GUI
{
    public partial class CreateBotGroupForm : Form
    {
        private Bot _bot;
        private Character _character;
        private DatabaseConnector _connector;
        public BotGroup NewGroup { get; private set; }

        public CreateBotGroupForm(Character forCharacter, Bot leader, DatabaseConnector connector)
        {
            this._bot = leader;
            this._character = forCharacter;
            this._connector = connector;
            InitializeComponent();
            this.Text = "Create new Bot Group";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var botGroup = _connector.CreateBotGroup(_bot, botNameTextBox.Text);
            if (botGroup != null)
            {
                if (_character.BotGroups == null)
                    _character.BotGroups = new List<BotGroup>();
                if (botGroup.Members == null)
                    botGroup.Members = new List<Bot>();

                var botToModify = (from b in _character.Bots where _bot.Id == b.Id select b).FirstOrDefault();
                botToModify.IsLeader = true;
                botGroup.Members.Add(botToModify);
                _character.BotGroups.Add(botGroup);
                this.NewGroup = botGroup;
            }
        }
    }
}
