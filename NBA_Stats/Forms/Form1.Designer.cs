namespace CSC236_RFarah_Final
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblAppDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayerSearch = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkStory1 = new System.Windows.Forms.LinkLabel();
            this.lnkStory2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppDescription
            // 
            this.lblAppDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAppDescription.Location = new System.Drawing.Point(294, 115);
            this.lblAppDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppDescription.Name = "lblAppDescription";
            this.lblAppDescription.Size = new System.Drawing.Size(734, 82);
            this.lblAppDescription.TabIndex = 0;
            this.lblAppDescription.Text = "label1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(500, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // btnPlayerSearch
            // 
            this.btnPlayerSearch.Location = new System.Drawing.Point(112, 643);
            this.btnPlayerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayerSearch.Name = "btnPlayerSearch";
            this.btnPlayerSearch.Size = new System.Drawing.Size(291, 59);
            this.btnPlayerSearch.TabIndex = 2;
            this.btnPlayerSearch.Text = "Player Search";
            this.btnPlayerSearch.UseVisualStyleBackColor = true;
            this.btnPlayerSearch.Click += new System.EventHandler(this.btnPlayerSearch_Click);
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.Location = new System.Drawing.Point(669, 643);
            this.btnLeaderboards.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(291, 59);
            this.btnLeaderboards.TabIndex = 2;
            this.btnLeaderboards.Text = "Leaderboards";
            this.btnLeaderboards.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(297, 181);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 423);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1092, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestPlayerToolStripMenuItem});
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            // 
            // requestPlayerToolStripMenuItem
            // 
            this.requestPlayerToolStripMenuItem.Name = "requestPlayerToolStripMenuItem";
            this.requestPlayerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.requestPlayerToolStripMenuItem.Text = "Request Player";
            this.requestPlayerToolStripMenuItem.Click += new System.EventHandler(this.requestPlayerToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "News";
            // 
            // lnkStory1
            // 
            this.lnkStory1.AutoSize = true;
            this.lnkStory1.LinkColor = System.Drawing.SystemColors.Control;
            this.lnkStory1.Location = new System.Drawing.Point(7, 181);
            this.lnkStory1.Name = "lnkStory1";
            this.lnkStory1.Size = new System.Drawing.Size(266, 17);
            this.lnkStory1.TabIndex = 6;
            this.lnkStory1.TabStop = true;
            this.lnkStory1.Text = "Doncic carries Maves to win over Blazers";
            this.lnkStory1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStory1_LinkClicked);
            // 
            // lnkStory2
            // 
            this.lnkStory2.AutoSize = true;
            this.lnkStory2.LinkColor = System.Drawing.SystemColors.Control;
            this.lnkStory2.Location = new System.Drawing.Point(7, 261);
            this.lnkStory2.Name = "lnkStory2";
            this.lnkStory2.Size = new System.Drawing.Size(194, 17);
            this.lnkStory2.TabIndex = 7;
            this.lnkStory2.TabStop = true;
            this.lnkStory2.Text = "76ers face big test in Toronto";
            this.lnkStory2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStory2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Location = new System.Drawing.Point(7, 351);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 17);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hayward\'s breakthru";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1092, 804);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lnkStory2);
            this.Controls.Add(this.lnkStory1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLeaderboards);
            this.Controls.Add(this.btnPlayerSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAppDescription);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayerSearch;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestPlayerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkStory1;
        private System.Windows.Forms.LinkLabel lnkStory2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

