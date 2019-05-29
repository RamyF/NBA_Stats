namespace CSC236_RFarah_Final.Forms
{
    partial class frmPlayerSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstvPlayers = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDraftYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmYearsExp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnViewPlayer = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstvPlayers
            // 
            this.lstvPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmPosition,
            this.clmAge,
            this.clmDraftYear,
            this.clmYearsExp,
            this.clmTeam});
            this.lstvPlayers.FullRowSelect = true;
            this.lstvPlayers.Location = new System.Drawing.Point(17, 60);
            this.lstvPlayers.Name = "lstvPlayers";
            this.lstvPlayers.Size = new System.Drawing.Size(890, 537);
            this.lstvPlayers.TabIndex = 1;
            this.lstvPlayers.UseCompatibleStateImageBehavior = false;
            this.lstvPlayers.View = System.Windows.Forms.View.Details;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 250;
            // 
            // clmPosition
            // 
            this.clmPosition.Text = "Position";
            this.clmPosition.Width = 100;
            // 
            // clmAge
            // 
            this.clmAge.Text = "Age";
            // 
            // clmDraftYear
            // 
            this.clmDraftYear.Text = "Draft Year";
            this.clmDraftYear.Width = 120;
            // 
            // clmYearsExp
            // 
            this.clmYearsExp.Text = "Years Exp";
            this.clmYearsExp.Width = 150;
            // 
            // clmTeam
            // 
            this.clmTeam.Text = "Team";
            this.clmTeam.Width = 200;
            // 
            // btnViewPlayer
            // 
            this.btnViewPlayer.Location = new System.Drawing.Point(17, 617);
            this.btnViewPlayer.Name = "btnViewPlayer";
            this.btnViewPlayer.Size = new System.Drawing.Size(290, 50);
            this.btnViewPlayer.TabIndex = 2;
            this.btnViewPlayer.Text = "View Player";
            this.btnViewPlayer.UseVisualStyleBackColor = true;
            this.btnViewPlayer.Click += new System.EventHandler(this.btnViewPlayer_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(617, 617);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(290, 50);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // frmPlayerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(920, 726);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnViewPlayer);
            this.Controls.Add(this.lstvPlayers);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPlayerSearch";
            this.Text = "Player Search";
            this.Load += new System.EventHandler(this.frmPlayerSearch_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstvPlayers;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmAge;
        private System.Windows.Forms.ColumnHeader clmDraftYear;
        private System.Windows.Forms.ColumnHeader clmYearsExp;
        private System.Windows.Forms.ColumnHeader clmTeam;
        private System.Windows.Forms.ColumnHeader clmPosition;
        private System.Windows.Forms.Button btnViewPlayer;
        private System.Windows.Forms.Button btnMainMenu;
    }
}