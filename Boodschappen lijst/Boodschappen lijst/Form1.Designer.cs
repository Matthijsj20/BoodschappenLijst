namespace Boodschappen_lijst
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.CBBoodschap = new System.Windows.Forms.ComboBox();
            this.BTAddToList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTAddToWhat = new System.Windows.Forms.Button();
            this.LW1 = new System.Windows.Forms.ListView();
            this.Boodschap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.BTSendMail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBDestination = new System.Windows.Forms.TextBox();
            this.TBNotes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CHBRemberPass = new System.Windows.Forms.CheckBox();
            this.BTDeleteEntireList = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBBoodschap
            // 
            this.CBBoodschap.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CBBoodschap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBoodschap.FormattingEnabled = true;
            this.CBBoodschap.Items.AddRange(new object[] {
            "Ei(1stuk)",
            "Kaas(1 blok)",
            "Melk(1liter)"});
            this.CBBoodschap.Location = new System.Drawing.Point(9, 54);
            this.CBBoodschap.Name = "CBBoodschap";
            this.CBBoodschap.Size = new System.Drawing.Size(326, 33);
            this.CBBoodschap.Sorted = true;
            this.CBBoodschap.TabIndex = 1;
            // 
            // BTAddToList
            // 
            this.BTAddToList.Location = new System.Drawing.Point(9, 93);
            this.BTAddToList.Name = "BTAddToList";
            this.BTAddToList.Size = new System.Drawing.Size(389, 34);
            this.BTAddToList.TabIndex = 3;
            this.BTAddToList.Text = "Voeg toe aan boodschappenlijst";
            this.BTAddToList.UseVisualStyleBackColor = true;
            this.BTAddToList.Click += new System.EventHandler(this.BTAddToList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Boodschap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aantal";
            // 
            // TBAmount
            // 
            this.TBAmount.Location = new System.Drawing.Point(341, 54);
            this.TBAmount.MaxLength = 3;
            this.TBAmount.Name = "TBAmount";
            this.TBAmount.Size = new System.Drawing.Size(57, 30);
            this.TBAmount.TabIndex = 7;
            this.TBAmount.Visible = false;
            this.TBAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.BTAddToWhat);
            this.groupBox1.Controls.Add(this.TBAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BTAddToList);
            this.groupBox1.Controls.Add(this.CBBoodschap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voeg boodschap toe";
            this.groupBox1.Visible = false;
            // 
            // BTAddToWhat
            // 
            this.BTAddToWhat.Location = new System.Drawing.Point(9, 133);
            this.BTAddToWhat.Name = "BTAddToWhat";
            this.BTAddToWhat.Size = new System.Drawing.Size(389, 34);
            this.BTAddToWhat.TabIndex = 8;
            this.BTAddToWhat.Text = "Beheer producten";
            this.BTAddToWhat.UseVisualStyleBackColor = true;
            this.BTAddToWhat.Click += new System.EventHandler(this.BTAddToWhat_Click);
            // 
            // LW1
            // 
            this.LW1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LW1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Boodschap,
            this.Aantal});
            this.LW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LW1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LW1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LW1.HideSelection = false;
            this.LW1.Location = new System.Drawing.Point(545, 23);
            this.LW1.MultiSelect = false;
            this.LW1.Name = "LW1";
            this.LW1.Size = new System.Drawing.Size(556, 537);
            this.LW1.TabIndex = 11;
            this.LW1.UseCompatibleStateImageBehavior = false;
            this.LW1.View = System.Windows.Forms.View.Details;
            this.LW1.Visible = false;
            // 
            // Boodschap
            // 
            this.Boodschap.Text = "Boodschap";
            this.Boodschap.Width = 452;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 90;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(545, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Verwijder van lijst";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTSendMail
            // 
            this.BTSendMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSendMail.Location = new System.Drawing.Point(21, 566);
            this.BTSendMail.Name = "BTSendMail";
            this.BTSendMail.Size = new System.Drawing.Size(476, 44);
            this.BTSendMail.TabIndex = 13;
            this.BTSendMail.Text = "Verzend mail";
            this.BTSendMail.UseVisualStyleBackColor = true;
            this.BTSendMail.Visible = false;
            this.BTSendMail.Click += new System.EventHandler(this.BTSendMail_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Van:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wachtwoord";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Naar:";
            this.label5.Visible = false;
            // 
            // TBUsername
            // 
            this.TBUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsername.Location = new System.Drawing.Point(21, 231);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(226, 30);
            this.TBUsername.TabIndex = 17;
            this.TBUsername.Visible = false;
            // 
            // TBPassword
            // 
            this.TBPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPassword.Location = new System.Drawing.Point(21, 301);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(226, 30);
            this.TBPassword.TabIndex = 18;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.Visible = false;
            // 
            // TBDestination
            // 
            this.TBDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDestination.Location = new System.Drawing.Point(21, 389);
            this.TBDestination.Name = "TBDestination";
            this.TBDestination.Size = new System.Drawing.Size(226, 30);
            this.TBDestination.TabIndex = 19;
            this.TBDestination.Text = "Jacobsjhcm@home.nl";
            this.TBDestination.Visible = false;
            // 
            // TBNotes
            // 
            this.TBNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNotes.Location = new System.Drawing.Point(21, 464);
            this.TBNotes.Multiline = true;
            this.TBNotes.Name = "TBNotes";
            this.TBNotes.Size = new System.Drawing.Size(476, 96);
            this.TBNotes.TabIndex = 20;
            this.TBNotes.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Opmerkingen";
            this.label6.Visible = false;
            // 
            // CHBRemberPass
            // 
            this.CHBRemberPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CHBRemberPass.AutoSize = true;
            this.CHBRemberPass.Location = new System.Drawing.Point(264, 313);
            this.CHBRemberPass.Name = "CHBRemberPass";
            this.CHBRemberPass.Size = new System.Drawing.Size(128, 17);
            this.CHBRemberPass.TabIndex = 22;
            this.CHBRemberPass.Text = "Onthoud wachtwoord";
            this.CHBRemberPass.UseVisualStyleBackColor = true;
            this.CHBRemberPass.Visible = false;
            // 
            // BTDeleteEntireList
            // 
            this.BTDeleteEntireList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTDeleteEntireList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDeleteEntireList.Location = new System.Drawing.Point(830, 566);
            this.BTDeleteEntireList.Name = "BTDeleteEntireList";
            this.BTDeleteEntireList.Size = new System.Drawing.Size(271, 44);
            this.BTDeleteEntireList.TabIndex = 23;
            this.BTDeleteEntireList.Text = "Verwijder hele lijst";
            this.BTDeleteEntireList.UseVisualStyleBackColor = true;
            this.BTDeleteEntireList.Visible = false;
            this.BTDeleteEntireList.Click += new System.EventHandler(this.BTDeleteEntireList_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1113, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTDeleteEntireList);
            this.Controls.Add(this.CHBRemberPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBNotes);
            this.Controls.Add(this.TBDestination);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTSendMail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LW1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boodschappen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBBoodschap;
        private System.Windows.Forms.Button BTAddToList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTAddToWhat;
        private System.Windows.Forms.ListView LW1;
        private System.Windows.Forms.ColumnHeader Boodschap;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTSendMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBDestination;
        private System.Windows.Forms.TextBox TBNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CHBRemberPass;
        private System.Windows.Forms.Button BTDeleteEntireList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

