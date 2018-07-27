namespace RaidAssist
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
            this.label3 = new System.Windows.Forms.Label();
            this.localCheckBox = new System.Windows.Forms.CheckBox();
            this.closeConnectionButton = new System.Windows.Forms.Button();
            this.botsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(78, 11);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(160, 20);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Text = "proxeeus";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(78, 38);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(160, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "jerome2110";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(163, 87);
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
            this.characterComboBox.Location = new System.Drawing.Point(347, 11);
            this.characterComboBox.Name = "characterComboBox";
            this.characterComboBox.Size = new System.Drawing.Size(241, 21);
            this.characterComboBox.TabIndex = 5;
            this.characterComboBox.SelectedIndexChanged += new System.EventHandler(this.characterComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select a character:";
            // 
            // localCheckBox
            // 
            this.localCheckBox.AutoSize = true;
            this.localCheckBox.Checked = true;
            this.localCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.localCheckBox.Location = new System.Drawing.Point(129, 64);
            this.localCheckBox.Name = "localCheckBox";
            this.localCheckBox.Size = new System.Drawing.Size(109, 17);
            this.localCheckBox.TabIndex = 7;
            this.localCheckBox.Text = "Local login server";
            this.localCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.localCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeConnectionButton
            // 
            this.closeConnectionButton.Location = new System.Drawing.Point(82, 87);
            this.closeConnectionButton.Name = "closeConnectionButton";
            this.closeConnectionButton.Size = new System.Drawing.Size(75, 23);
            this.closeConnectionButton.TabIndex = 8;
            this.closeConnectionButton.Text = "Close";
            this.closeConnectionButton.UseVisualStyleBackColor = true;
            this.closeConnectionButton.Click += new System.EventHandler(this.closeConnectionButton_Click);
            // 
            // botsListBox
            // 
            this.botsListBox.FormattingEnabled = true;
            this.botsListBox.Location = new System.Drawing.Point(347, 38);
            this.botsListBox.Name = "botsListBox";
            this.botsListBox.Size = new System.Drawing.Size(241, 368);
            this.botsListBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bots:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botsListBox);
            this.Controls.Add(this.closeConnectionButton);
            this.Controls.Add(this.localCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.characterComboBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EQEmu Raid Assist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox characterComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox localCheckBox;
        private System.Windows.Forms.Button closeConnectionButton;
        private System.Windows.Forms.ListBox botsListBox;
        private System.Windows.Forms.Label label4;
    }
}

