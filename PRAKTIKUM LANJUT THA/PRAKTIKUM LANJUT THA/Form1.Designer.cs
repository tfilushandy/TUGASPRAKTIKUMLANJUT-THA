namespace PRAKTIKUM_LANJUT_THA
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDPLAYERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITMANAGERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneladdplayer = new System.Windows.Forms.Panel();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.PLAYERID = new System.Windows.Forms.Label();
            this.txtboxplayerid = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtboxteamname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxnationality = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxweight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxheight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxpos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxteamnumber = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.Label();
            this.txtboxnama = new System.Windows.Forms.TextBox();
            this.paneleditmanager = new System.Windows.Forms.Panel();
            this.dgvmanager1 = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbteamname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvmanager2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvteamlist = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbteamname1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.paneladdplayer.SuspendLayout();
            this.paneleditmanager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanager2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteamlist)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDPLAYERToolStripMenuItem,
            this.eDITMANAGERToolStripMenuItem,
            this.rEMOVEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDDPLAYERToolStripMenuItem
            // 
            this.aDDPLAYERToolStripMenuItem.Name = "aDDPLAYERToolStripMenuItem";
            this.aDDPLAYERToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aDDPLAYERToolStripMenuItem.Text = "ADD PLAYER";
            this.aDDPLAYERToolStripMenuItem.Click += new System.EventHandler(this.aDDPLAYERToolStripMenuItem_Click);
            // 
            // eDITMANAGERToolStripMenuItem
            // 
            this.eDITMANAGERToolStripMenuItem.Name = "eDITMANAGERToolStripMenuItem";
            this.eDITMANAGERToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.eDITMANAGERToolStripMenuItem.Text = "EDIT MANAGER";
            this.eDITMANAGERToolStripMenuItem.Click += new System.EventHandler(this.eDITMANAGERToolStripMenuItem_Click);
            // 
            // rEMOVEToolStripMenuItem
            // 
            this.rEMOVEToolStripMenuItem.Name = "rEMOVEToolStripMenuItem";
            this.rEMOVEToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.rEMOVEToolStripMenuItem.Text = "REMOVE PLAYER";
            this.rEMOVEToolStripMenuItem.Click += new System.EventHandler(this.rEMOVEToolStripMenuItem_Click);
            // 
            // paneladdplayer
            // 
            this.paneladdplayer.Controls.Add(this.dtp1);
            this.paneladdplayer.Controls.Add(this.PLAYERID);
            this.paneladdplayer.Controls.Add(this.txtboxplayerid);
            this.paneladdplayer.Controls.Add(this.btnadd);
            this.paneladdplayer.Controls.Add(this.txtboxteamname);
            this.paneladdplayer.Controls.Add(this.label6);
            this.paneladdplayer.Controls.Add(this.txtboxnationality);
            this.paneladdplayer.Controls.Add(this.label1);
            this.paneladdplayer.Controls.Add(this.label5);
            this.paneladdplayer.Controls.Add(this.txtboxweight);
            this.paneladdplayer.Controls.Add(this.label4);
            this.paneladdplayer.Controls.Add(this.txtboxheight);
            this.paneladdplayer.Controls.Add(this.label3);
            this.paneladdplayer.Controls.Add(this.txtboxpos);
            this.paneladdplayer.Controls.Add(this.label2);
            this.paneladdplayer.Controls.Add(this.txtboxteamnumber);
            this.paneladdplayer.Controls.Add(this.Nama);
            this.paneladdplayer.Controls.Add(this.txtboxnama);
            this.paneladdplayer.Location = new System.Drawing.Point(13, 40);
            this.paneladdplayer.Name = "paneladdplayer";
            this.paneladdplayer.Size = new System.Drawing.Size(540, 250);
            this.paneladdplayer.TabIndex = 1;
            this.paneladdplayer.Visible = false;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(264, 85);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(210, 20);
            this.dtp1.TabIndex = 17;
            // 
            // PLAYERID
            // 
            this.PLAYERID.AutoSize = true;
            this.PLAYERID.Location = new System.Drawing.Point(20, 192);
            this.PLAYERID.Name = "PLAYERID";
            this.PLAYERID.Size = new System.Drawing.Size(63, 13);
            this.PLAYERID.TabIndex = 16;
            this.PLAYERID.Text = "PLAYER ID";
            // 
            // txtboxplayerid
            // 
            this.txtboxplayerid.Location = new System.Drawing.Point(113, 189);
            this.txtboxplayerid.Name = "txtboxplayerid";
            this.txtboxplayerid.Size = new System.Drawing.Size(100, 20);
            this.txtboxplayerid.TabIndex = 15;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(264, 123);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(116, 37);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtboxteamname
            // 
            this.txtboxteamname.FormattingEnabled = true;
            this.txtboxteamname.Location = new System.Drawing.Point(345, 48);
            this.txtboxteamname.Name = "txtboxteamname";
            this.txtboxteamname.Size = new System.Drawing.Size(129, 21);
            this.txtboxteamname.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TEAM NAME";
            // 
            // txtboxnationality
            // 
            this.txtboxnationality.FormattingEnabled = true;
            this.txtboxnationality.Location = new System.Drawing.Point(345, 21);
            this.txtboxnationality.Name = "txtboxnationality";
            this.txtboxnationality.Size = new System.Drawing.Size(129, 21);
            this.txtboxnationality.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NATIONALITY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "WEIGHT";
            // 
            // txtboxweight
            // 
            this.txtboxweight.Location = new System.Drawing.Point(113, 153);
            this.txtboxweight.Name = "txtboxweight";
            this.txtboxweight.Size = new System.Drawing.Size(100, 20);
            this.txtboxweight.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "HEIGHT";
            // 
            // txtboxheight
            // 
            this.txtboxheight.Location = new System.Drawing.Point(113, 120);
            this.txtboxheight.Name = "txtboxheight";
            this.txtboxheight.Size = new System.Drawing.Size(100, 20);
            this.txtboxheight.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "POS";
            // 
            // txtboxpos
            // 
            this.txtboxpos.Location = new System.Drawing.Point(113, 85);
            this.txtboxpos.Name = "txtboxpos";
            this.txtboxpos.Size = new System.Drawing.Size(100, 20);
            this.txtboxpos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TEAM NUMBER";
            // 
            // txtboxteamnumber
            // 
            this.txtboxteamnumber.Location = new System.Drawing.Point(113, 53);
            this.txtboxteamnumber.Name = "txtboxteamnumber";
            this.txtboxteamnumber.Size = new System.Drawing.Size(100, 20);
            this.txtboxteamnumber.TabIndex = 2;
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(20, 24);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(38, 13);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "NAMA";
            // 
            // txtboxnama
            // 
            this.txtboxnama.Location = new System.Drawing.Point(113, 21);
            this.txtboxnama.Name = "txtboxnama";
            this.txtboxnama.Size = new System.Drawing.Size(100, 20);
            this.txtboxnama.TabIndex = 0;
            // 
            // paneleditmanager
            // 
            this.paneleditmanager.Controls.Add(this.dgvmanager2);
            this.paneleditmanager.Controls.Add(this.dgvmanager1);
            this.paneleditmanager.Controls.Add(this.btnupdate);
            this.paneleditmanager.Controls.Add(this.cmbteamname);
            this.paneleditmanager.Controls.Add(this.label7);
            this.paneleditmanager.Location = new System.Drawing.Point(577, 40);
            this.paneleditmanager.Name = "paneleditmanager";
            this.paneleditmanager.Size = new System.Drawing.Size(666, 290);
            this.paneleditmanager.TabIndex = 15;
            this.paneleditmanager.Visible = false;
            // 
            // dgvmanager1
            // 
            this.dgvmanager1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmanager1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanager1.Location = new System.Drawing.Point(33, 48);
            this.dgvmanager1.Name = "dgvmanager1";
            this.dgvmanager1.Size = new System.Drawing.Size(301, 150);
            this.dgvmanager1.TabIndex = 15;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(33, 210);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(68, 25);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "ADD";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cmbteamname
            // 
            this.cmbteamname.FormattingEnabled = true;
            this.cmbteamname.Location = new System.Drawing.Point(107, 16);
            this.cmbteamname.Name = "cmbteamname";
            this.cmbteamname.Size = new System.Drawing.Size(129, 21);
            this.cmbteamname.TabIndex = 13;
            this.cmbteamname.SelectionChangeCommitted += new System.EventHandler(this.cmbteamname_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "TEAM NAME";
            // 
            // dgvmanager2
            // 
            this.dgvmanager2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmanager2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanager2.Location = new System.Drawing.Point(340, 48);
            this.dgvmanager2.Name = "dgvmanager2";
            this.dgvmanager2.Size = new System.Drawing.Size(294, 150);
            this.dgvmanager2.TabIndex = 16;
            this.dgvmanager2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmanager2_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvteamlist);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbteamname1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(13, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 290);
            this.panel1.TabIndex = 17;
            // 
            // dgvteamlist
            // 
            this.dgvteamlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvteamlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteamlist.Location = new System.Drawing.Point(33, 48);
            this.dgvteamlist.Name = "dgvteamlist";
            this.dgvteamlist.Size = new System.Drawing.Size(465, 150);
            this.dgvteamlist.TabIndex = 15;
            this.dgvteamlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvteamlist_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbteamname1
            // 
            this.cmbteamname1.FormattingEnabled = true;
            this.cmbteamname1.Location = new System.Drawing.Point(107, 16);
            this.cmbteamname1.Name = "cmbteamname1";
            this.cmbteamname1.Size = new System.Drawing.Size(129, 21);
            this.cmbteamname1.TabIndex = 13;
            this.cmbteamname1.SelectionChangeCommitted += new System.EventHandler(this.cmbteamname1_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "TEAM NAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneleditmanager);
            this.Controls.Add(this.paneladdplayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paneladdplayer.ResumeLayout(false);
            this.paneladdplayer.PerformLayout();
            this.paneleditmanager.ResumeLayout(false);
            this.paneleditmanager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanager2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteamlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDPLAYERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITMANAGERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEToolStripMenuItem;
        private System.Windows.Forms.Panel paneladdplayer;
        private System.Windows.Forms.TextBox txtboxnama;
        private System.Windows.Forms.ComboBox txtboxteamname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtboxnationality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxweight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxheight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxpos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxteamnumber;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel paneleditmanager;
        private System.Windows.Forms.DataGridView dgvmanager1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox cmbteamname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PLAYERID;
        private System.Windows.Forms.TextBox txtboxplayerid;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView dgvmanager2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvteamlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbteamname1;
        private System.Windows.Forms.Label label8;
    }
}

