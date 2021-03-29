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
    public partial class BotInventory : Form
    {
        private Bot _bot;
        private DatabaseConnector _connector;

        // TODO: refactor the hardcoded part :/
        private string _itemURL = @"http://localhost/eqemuallaclone/?a=item&id={0}";

        public BotInventory(Bot bot, DatabaseConnector connector)
        {
            this._bot = bot;
            this._connector = connector;
            InitializeComponent();
        }

        private void BotInventory_Load(object sender, EventArgs e)
        {
            this.Text = string.Format(this.Text, this._bot.Name);
            this.botInventoryGroupBox.Text = string.Format(this.botInventoryGroupBox.Text, this._bot.Name);
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            foreach(var entry in this._bot.Inventory.Items)
            {
                switch(entry.SlotId)
                {
                    case 1:
                        leftEarLinkLabel.Text = entry.ItemName;
                        leftEarLinkLabel.Links.Add(0,0,string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 2:
                        headLinkLabel.Text = entry.ItemName;
                        headLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 3:
                        faceLinkLabel.Text = entry.ItemName;
                        faceLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 4:
                        rightEarLinkLabel.Text = entry.ItemName;
                        rightEarLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 5:
                        neckLinkLabel.Text = entry.ItemName;
                        neckLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 6:
                        shouldersLinkLabel.Text = entry.ItemName;
                        shouldersLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 7:
                        armsLinkLabel.Text = entry.ItemName;
                        armsLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 8:
                        backLinkLabel.Text = entry.ItemName;
                        backLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 9:
                        leftWristLinkLabel.Text = entry.ItemName;
                        leftWristLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 10:
                        rightWristLinkLabel.Text = entry.ItemName;
                        rightWristLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 11:
                        rangeLinkLabel.Text = entry.ItemName;
                        rangeLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 12:
                        handsLinkLabel.Text = entry.ItemName;
                        handsLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 13:
                        primaryLinkLabel.Text = entry.ItemName;
                        primaryLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 14:
                        secondaryLinkLabel.Text = entry.ItemName;
                        secondaryLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 15:
                        leftFingerLinkLabel.Text = entry.ItemName;
                        leftFingerLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 16:
                        rightFingerLinkLabel.Text = entry.ItemName;
                        rightFingerLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 17:
                        chestLinkLabel.Text = entry.ItemName;
                        chestLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 18:
                        legsLinkLabel.Text = entry.ItemName;
                        legsLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 19:
                        feetLinkLabel.Text = entry.ItemName;
                        feetLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 20:
                        beltLinkLabel.Text = entry.ItemName;
                        beltLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    case 22:
                        ammoLinkLabel.Text = entry.ItemName;
                        ammoLinkLabel.Links.Add(0, 0, string.Format(this._itemURL, entry.ItemId));
                        break;
                    default:
                        break;
                }
            }
        }

        private void ProcessLink(LinkLabelLinkClickedEventArgs e)
        {
            webBrowser.Navigate(e.Link.LinkData.ToString());
        }

        #region Links Event Handlers
        private void LeftEarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void HeadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void FaceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void NeckLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void ShouldersLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void ArmsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void BackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void LeftWristLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void RangeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void HandsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void RightEarLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void PrimaryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void SecondaryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void LeftFingerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void RightFingerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void ChestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void LegsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void RightWristLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void BeltLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void FeetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }

        private void AmmoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessLink(e);
        }
        #endregion
    }
}
