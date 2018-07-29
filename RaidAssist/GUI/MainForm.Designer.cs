namespace RaidAssist.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.characterComboBox = new System.Windows.Forms.ComboBox();
            this.localCheckBox = new System.Windows.Forms.CheckBox();
            this.closeConnectionButton = new System.Windows.Forms.Button();
            this.botGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.botsListBox = new System.Windows.Forms.ListBox();
            this.botGroupMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            this.createGroupButton = new System.Windows.Forms.Button();
            this.renameGroupButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addBotToGroup = new System.Windows.Forms.Button();
            this.botRemoveFromGroup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(67, 19);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(160, 20);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Text = "proxeeus";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(67, 46);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(160, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "jerome2110";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(152, 95);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // characterComboBox
            // 
            this.characterComboBox.FormattingEnabled = true;
            this.characterComboBox.Location = new System.Drawing.Point(6, 19);
            this.characterComboBox.Name = "characterComboBox";
            this.characterComboBox.Size = new System.Drawing.Size(241, 21);
            this.characterComboBox.TabIndex = 5;
            this.characterComboBox.SelectedIndexChanged += new System.EventHandler(this.characterComboBox_SelectedIndexChanged);
            // 
            // localCheckBox
            // 
            this.localCheckBox.AutoSize = true;
            this.localCheckBox.Checked = true;
            this.localCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.localCheckBox.Location = new System.Drawing.Point(118, 72);
            this.localCheckBox.Name = "localCheckBox";
            this.localCheckBox.Size = new System.Drawing.Size(109, 17);
            this.localCheckBox.TabIndex = 7;
            this.localCheckBox.Text = "Local login server";
            this.localCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.localCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeConnectionButton
            // 
            this.closeConnectionButton.Location = new System.Drawing.Point(71, 95);
            this.closeConnectionButton.Name = "closeConnectionButton";
            this.closeConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.closeConnectionButton.TabIndex = 8;
            this.closeConnectionButton.Text = "Close";
            this.closeConnectionButton.UseVisualStyleBackColor = true;
            this.closeConnectionButton.Click += new System.EventHandler(this.closeConnectionButton_Click);
            // 
            // botGroupsComboBox
            // 
            this.botGroupsComboBox.FormattingEnabled = true;
            this.botGroupsComboBox.Location = new System.Drawing.Point(12, 19);
            this.botGroupsComboBox.Name = "botGroupsComboBox";
            this.botGroupsComboBox.Size = new System.Drawing.Size(235, 21);
            this.botGroupsComboBox.TabIndex = 12;
            this.botGroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.botGroupsComboBox_SelectedIndexChanged);
            // 
            // botsListBox
            // 
            this.botsListBox.FormattingEnabled = true;
            this.botsListBox.Location = new System.Drawing.Point(6, 46);
            this.botsListBox.Name = "botsListBox";
            this.botsListBox.Size = new System.Drawing.Size(241, 329);
            this.botsListBox.TabIndex = 9;
            this.botsListBox.SelectedIndexChanged += new System.EventHandler(this.botsListBox_SelectedIndexChanged);
            // 
            // botGroupMembersListBox
            // 
            this.botGroupMembersListBox.FormattingEnabled = true;
            this.botGroupMembersListBox.Location = new System.Drawing.Point(12, 46);
            this.botGroupMembersListBox.Name = "botGroupMembersListBox";
            this.botGroupMembersListBox.Size = new System.Drawing.Size(235, 82);
            this.botGroupMembersListBox.TabIndex = 9;
            this.botGroupMembersListBox.SelectedIndexChanged += new System.EventHandler(this.botGroupMembersListBox_SelectedIndexChanged);
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(12, 187);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(104, 23);
            this.deleteGroupButton.TabIndex = 13;
            this.deleteGroupButton.Text = "Delete";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // createGroupButton
            // 
            this.createGroupButton.Location = new System.Drawing.Point(12, 134);
            this.createGroupButton.Name = "createGroupButton";
            this.createGroupButton.Size = new System.Drawing.Size(104, 23);
            this.createGroupButton.TabIndex = 14;
            this.createGroupButton.Text = "Create";
            this.createGroupButton.UseVisualStyleBackColor = true;
            this.createGroupButton.Click += new System.EventHandler(this.createGroupButton_Click);
            // 
            // renameGroupButton
            // 
            this.renameGroupButton.Location = new System.Drawing.Point(12, 161);
            this.renameGroupButton.Name = "renameGroupButton";
            this.renameGroupButton.Size = new System.Drawing.Size(104, 23);
            this.renameGroupButton.TabIndex = 15;
            this.renameGroupButton.Text = "Rename";
            this.renameGroupButton.UseVisualStyleBackColor = true;
            this.renameGroupButton.Click += new System.EventHandler(this.renameGroupButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createGroupButton);
            this.groupBox1.Controls.Add(this.renameGroupButton);
            this.groupBox1.Controls.Add(this.botGroupsComboBox);
            this.groupBox1.Controls.Add(this.deleteGroupButton);
            this.groupBox1.Controls.Add(this.botGroupMembersListBox);
            this.groupBox1.Location = new System.Drawing.Point(550, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 215);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bot Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botRemoveFromGroup);
            this.groupBox2.Controls.Add(this.addBotToGroup);
            this.groupBox2.Location = new System.Drawing.Point(550, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 174);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot Group Member";
            // 
            // addBotToGroup
            // 
            this.addBotToGroup.Location = new System.Drawing.Point(12, 19);
            this.addBotToGroup.Name = "addBotToGroup";
            this.addBotToGroup.Size = new System.Drawing.Size(104, 23);
            this.addBotToGroup.TabIndex = 18;
            this.addBotToGroup.Text = "Add";
            this.addBotToGroup.UseVisualStyleBackColor = true;
            this.addBotToGroup.Click += new System.EventHandler(this.addBotToGroup_Click);
            // 
            // botRemoveFromGroup
            // 
            this.botRemoveFromGroup.Location = new System.Drawing.Point(12, 48);
            this.botRemoveFromGroup.Name = "botRemoveFromGroup";
            this.botRemoveFromGroup.Size = new System.Drawing.Size(104, 23);
            this.botRemoveFromGroup.TabIndex = 19;
            this.botRemoveFromGroup.Text = "Remove";
            this.botRemoveFromGroup.UseVisualStyleBackColor = true;
            this.botRemoveFromGroup.Click += new System.EventHandler(this.botRemoveFromGroup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loginTextBox);
            this.groupBox3.Controls.Add(this.passwordTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.connectButton);
            this.groupBox3.Controls.Add(this.closeConnectionButton);
            this.groupBox3.Controls.Add(this.localCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 129);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Please enter your login info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.characterComboBox);
            this.groupBox4.Controls.Add(this.botsListBox);
            this.groupBox4.Location = new System.Drawing.Point(270, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 394);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select your character";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 417);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EQEmu Raid Assist";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox characterComboBox;
        private System.Windows.Forms.CheckBox localCheckBox;
        private System.Windows.Forms.Button closeConnectionButton;
        private System.Windows.Forms.ComboBox botGroupsComboBox;
        private System.Windows.Forms.ListBox botsListBox;
        private System.Windows.Forms.ListBox botGroupMembersListBox;
        private System.Windows.Forms.Button deleteGroupButton;
        private System.Windows.Forms.Button createGroupButton;
        private System.Windows.Forms.Button renameGroupButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botRemoveFromGroup;
        private System.Windows.Forms.Button addBotToGroup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

