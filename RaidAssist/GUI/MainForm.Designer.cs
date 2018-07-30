﻿namespace RaidAssist.GUI
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
            this.botRemoveFromGroup = new System.Windows.Forms.Button();
            this.addBotToGroup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.botGroupsTab = new System.Windows.Forms.TabPage();
            this.healRotationsTab = new System.Windows.Forms.TabPage();
            this.rotationMembersListBox = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.rotationTargetTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.criticalHPPlateTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.criticalHPChainTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.criticalHPLeatherTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.criticalHPClothTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.criticalHPBaseTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.safeHPPlateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.safeHPChainTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.safeHPLeatherTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.safeHPClothTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.safeHPBaseTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.castingOverrideTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adaptiveTargetingTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fastHealsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.rotationsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.botGroupsTab.SuspendLayout();
            this.healRotationsTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.botsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.botsListBox.Size = new System.Drawing.Size(241, 342);
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
            this.groupBox1.Location = new System.Drawing.Point(286, 5);
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
            this.groupBox2.Location = new System.Drawing.Point(286, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 174);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot Group Member";
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
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 394);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select your character";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.botGroupsTab);
            this.tabControl1.Controls.Add(this.healRotationsTab);
            this.tabControl1.Location = new System.Drawing.Point(264, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 435);
            this.tabControl1.TabIndex = 20;
            // 
            // botGroupsTab
            // 
            this.botGroupsTab.Controls.Add(this.groupBox4);
            this.botGroupsTab.Controls.Add(this.groupBox1);
            this.botGroupsTab.Controls.Add(this.groupBox2);
            this.botGroupsTab.Location = new System.Drawing.Point(4, 22);
            this.botGroupsTab.Name = "botGroupsTab";
            this.botGroupsTab.Padding = new System.Windows.Forms.Padding(3);
            this.botGroupsTab.Size = new System.Drawing.Size(550, 409);
            this.botGroupsTab.TabIndex = 0;
            this.botGroupsTab.Text = "Bots & Groups";
            this.botGroupsTab.UseVisualStyleBackColor = true;
            // 
            // healRotationsTab
            // 
            this.healRotationsTab.Controls.Add(this.rotationMembersListBox);
            this.healRotationsTab.Controls.Add(this.groupBox5);
            this.healRotationsTab.Controls.Add(this.rotationsListBox);
            this.healRotationsTab.Location = new System.Drawing.Point(4, 22);
            this.healRotationsTab.Name = "healRotationsTab";
            this.healRotationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.healRotationsTab.Size = new System.Drawing.Size(550, 409);
            this.healRotationsTab.TabIndex = 1;
            this.healRotationsTab.Text = "Heal Rotations";
            this.healRotationsTab.UseVisualStyleBackColor = true;
            // 
            // rotationMembersListBox
            // 
            this.rotationMembersListBox.FormattingEnabled = true;
            this.rotationMembersListBox.Location = new System.Drawing.Point(116, 6);
            this.rotationMembersListBox.Name = "rotationMembersListBox";
            this.rotationMembersListBox.Size = new System.Drawing.Size(105, 394);
            this.rotationMembersListBox.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.rotationTargetTextBox);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.criticalHPPlateTextBox);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.criticalHPChainTextBox);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.criticalHPLeatherTextBox);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.criticalHPClothTextBox);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.criticalHPBaseTextBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.safeHPPlateTextBox);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.safeHPChainTextBox);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.safeHPLeatherTextBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.safeHPClothTextBox);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.safeHPBaseTextBox);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.castingOverrideTextBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.adaptiveTargetingTextBox);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.fastHealsTextBox);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.intervalTextBox);
            this.groupBox5.Location = new System.Drawing.Point(227, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 400);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Heal rotation properties";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 298);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Rotation target:";
            // 
            // rotationTargetTextBox
            // 
            this.rotationTargetTextBox.Location = new System.Drawing.Point(103, 295);
            this.rotationTargetTextBox.MaxLength = 64;
            this.rotationTargetTextBox.Name = "rotationTargetTextBox";
            this.rotationTargetTextBox.Size = new System.Drawing.Size(208, 20);
            this.rotationTargetTextBox.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Critical HP Plate:";
            // 
            // criticalHPPlateTextBox
            // 
            this.criticalHPPlateTextBox.Location = new System.Drawing.Point(273, 234);
            this.criticalHPPlateTextBox.Name = "criticalHPPlateTextBox";
            this.criticalHPPlateTextBox.Size = new System.Drawing.Size(38, 20);
            this.criticalHPPlateTextBox.TabIndex = 26;
            this.criticalHPPlateTextBox.Text = "30";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Critical HP Chain:";
            // 
            // criticalHPChainTextBox
            // 
            this.criticalHPChainTextBox.Location = new System.Drawing.Point(273, 207);
            this.criticalHPChainTextBox.Name = "criticalHPChainTextBox";
            this.criticalHPChainTextBox.Size = new System.Drawing.Size(38, 20);
            this.criticalHPChainTextBox.TabIndex = 24;
            this.criticalHPChainTextBox.Text = "35";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(169, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Critical HP Leather:";
            // 
            // criticalHPLeatherTextBox
            // 
            this.criticalHPLeatherTextBox.Location = new System.Drawing.Point(273, 180);
            this.criticalHPLeatherTextBox.Name = "criticalHPLeatherTextBox";
            this.criticalHPLeatherTextBox.Size = new System.Drawing.Size(38, 20);
            this.criticalHPLeatherTextBox.TabIndex = 22;
            this.criticalHPLeatherTextBox.Text = "40";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(184, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Critical HP Cloth:";
            // 
            // criticalHPClothTextBox
            // 
            this.criticalHPClothTextBox.Location = new System.Drawing.Point(273, 154);
            this.criticalHPClothTextBox.Name = "criticalHPClothTextBox";
            this.criticalHPClothTextBox.Size = new System.Drawing.Size(38, 20);
            this.criticalHPClothTextBox.TabIndex = 20;
            this.criticalHPClothTextBox.Text = "45";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(184, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Critical HP Base:";
            // 
            // criticalHPBaseTextBox
            // 
            this.criticalHPBaseTextBox.Location = new System.Drawing.Point(273, 128);
            this.criticalHPBaseTextBox.Name = "criticalHPBaseTextBox";
            this.criticalHPBaseTextBox.Size = new System.Drawing.Size(38, 20);
            this.criticalHPBaseTextBox.TabIndex = 18;
            this.criticalHPBaseTextBox.Text = "30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Safe HP Plate:";
            // 
            // safeHPPlateTextBox
            // 
            this.safeHPPlateTextBox.Location = new System.Drawing.Point(109, 234);
            this.safeHPPlateTextBox.Name = "safeHPPlateTextBox";
            this.safeHPPlateTextBox.Size = new System.Drawing.Size(38, 20);
            this.safeHPPlateTextBox.TabIndex = 16;
            this.safeHPPlateTextBox.Text = "75";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Safe HP Chain:";
            // 
            // safeHPChainTextBox
            // 
            this.safeHPChainTextBox.Location = new System.Drawing.Point(109, 207);
            this.safeHPChainTextBox.Name = "safeHPChainTextBox";
            this.safeHPChainTextBox.Size = new System.Drawing.Size(38, 20);
            this.safeHPChainTextBox.TabIndex = 14;
            this.safeHPChainTextBox.Text = "80";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Safe HP Leather:";
            // 
            // safeHPLeatherTextBox
            // 
            this.safeHPLeatherTextBox.Location = new System.Drawing.Point(109, 180);
            this.safeHPLeatherTextBox.Name = "safeHPLeatherTextBox";
            this.safeHPLeatherTextBox.Size = new System.Drawing.Size(38, 20);
            this.safeHPLeatherTextBox.TabIndex = 12;
            this.safeHPLeatherTextBox.Text = "90";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Safe HP Cloth:";
            // 
            // safeHPClothTextBox
            // 
            this.safeHPClothTextBox.Location = new System.Drawing.Point(109, 154);
            this.safeHPClothTextBox.Name = "safeHPClothTextBox";
            this.safeHPClothTextBox.Size = new System.Drawing.Size(38, 20);
            this.safeHPClothTextBox.TabIndex = 10;
            this.safeHPClothTextBox.Text = "95";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Safe HP Base:";
            // 
            // safeHPBaseTextBox
            // 
            this.safeHPBaseTextBox.Location = new System.Drawing.Point(109, 128);
            this.safeHPBaseTextBox.Name = "safeHPBaseTextBox";
            this.safeHPBaseTextBox.Size = new System.Drawing.Size(38, 20);
            this.safeHPBaseTextBox.TabIndex = 8;
            this.safeHPBaseTextBox.Text = "95";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Casting Override:";
            // 
            // castingOverrideTextBox
            // 
            this.castingOverrideTextBox.Location = new System.Drawing.Point(273, 67);
            this.castingOverrideTextBox.Name = "castingOverrideTextBox";
            this.castingOverrideTextBox.Size = new System.Drawing.Size(38, 20);
            this.castingOverrideTextBox.TabIndex = 6;
            this.castingOverrideTextBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adaptive Targeting:";
            // 
            // adaptiveTargetingTextBox
            // 
            this.adaptiveTargetingTextBox.Location = new System.Drawing.Point(109, 67);
            this.adaptiveTargetingTextBox.Name = "adaptiveTargetingTextBox";
            this.adaptiveTargetingTextBox.Size = new System.Drawing.Size(38, 20);
            this.adaptiveTargetingTextBox.TabIndex = 4;
            this.adaptiveTargetingTextBox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fast Heals:";
            // 
            // fastHealsTextBox
            // 
            this.fastHealsTextBox.Location = new System.Drawing.Point(273, 30);
            this.fastHealsTextBox.Name = "fastHealsTextBox";
            this.fastHealsTextBox.Size = new System.Drawing.Size(38, 20);
            this.fastHealsTextBox.TabIndex = 2;
            this.fastHealsTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Interval:";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(109, 30);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(38, 20);
            this.intervalTextBox.TabIndex = 0;
            this.intervalTextBox.Text = "2";
            // 
            // rotationsListBox
            // 
            this.rotationsListBox.FormattingEnabled = true;
            this.rotationsListBox.Location = new System.Drawing.Point(6, 6);
            this.rotationsListBox.Name = "rotationsListBox";
            this.rotationsListBox.Size = new System.Drawing.Size(105, 394);
            this.rotationsListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EQEmu Raid Assist";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.botGroupsTab.ResumeLayout(false);
            this.healRotationsTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage botGroupsTab;
        private System.Windows.Forms.TabPage healRotationsTab;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.ListBox rotationsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fastHealsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox adaptiveTargetingTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox castingOverrideTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox safeHPChainTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox safeHPLeatherTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox safeHPClothTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox safeHPBaseTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox criticalHPPlateTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox criticalHPChainTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox criticalHPLeatherTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox criticalHPClothTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox criticalHPBaseTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox safeHPPlateTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox rotationTargetTextBox;
        private System.Windows.Forms.ListBox rotationMembersListBox;
    }
}

