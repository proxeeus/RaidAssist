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
    public partial class RenameBotGroupForm : Form
    {
        private BotGroup _botGroup;
        private DatabaseConnector _connector;

        public RenameBotGroupForm(BotGroup botGroup, DatabaseConnector connector)
        {
            this._botGroup = botGroup;
            this._connector = connector;
            InitializeComponent();
            this.Text = string.Format("Rename Bot Group [{0}]", _botGroup.GroupName);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this._connector.RenameBotGroup(this._botGroup, botNameTextBox.Text))
                this._botGroup.GroupName = botNameTextBox.Text;
            else
                MessageBox.Show("Another Bot Group exists with that name, please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
