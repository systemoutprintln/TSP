namespace Traveling_Salesman
{
    partial class frmTSP
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
            this.panSales = new System.Windows.Forms.Panel();
            this.nudCities = new System.Windows.Forms.NumericUpDown();
            this.lblCities = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaxS = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.timTest = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblini = new System.Windows.Forms.Label();
            this.lblpChange = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panOpt = new System.Windows.Forms.Panel();
            this.chkBoltz = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStale = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runMultipleSameMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkARes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSales
            // 
            this.panSales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panSales.Location = new System.Drawing.Point(10, 39);
            this.panSales.Name = "panSales";
            this.panSales.Size = new System.Drawing.Size(400, 400);
            this.panSales.TabIndex = 0;
            this.panSales.Click += new System.EventHandler(this.panSales_Click);
            this.panSales.Paint += new System.Windows.Forms.PaintEventHandler(this.panSales_Paint);
            // 
            // nudCities
            // 
            this.nudCities.Location = new System.Drawing.Point(826, 55);
            this.nudCities.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCities.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCities.Name = "nudCities";
            this.nudCities.Size = new System.Drawing.Size(120, 20);
            this.nudCities.TabIndex = 1;
            this.nudCities.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCities
            // 
            this.lblCities.AutoSize = true;
            this.lblCities.Location = new System.Drawing.Point(826, 39);
            this.lblCities.Name = "lblCities";
            this.lblCities.Size = new System.Drawing.Size(83, 13);
            this.lblCities.TabIndex = 2;
            this.lblCities.Text = "Number of cities";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max. Speed";
            // 
            // nudMaxS
            // 
            this.nudMaxS.Location = new System.Drawing.Point(826, 94);
            this.nudMaxS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxS.Name = "nudMaxS";
            this.nudMaxS.Size = new System.Drawing.Size(120, 20);
            this.nudMaxS.TabIndex = 4;
            this.nudMaxS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(894, 426);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(52, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Distance:";
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(826, 144);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(13, 13);
            this.lblDist.TabIndex = 7;
            this.lblDist.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(826, 167);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(72, 13);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Min Distance:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(826, 190);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(13, 13);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "0";
            // 
            // timTest
            // 
            this.timTest.Interval = 1;
            this.timTest.Tick += new System.EventHandler(this.timTest_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ini Distance:";
            // 
            // lblini
            // 
            this.lblini.AutoSize = true;
            this.lblini.Location = new System.Drawing.Point(826, 238);
            this.lblini.Name = "lblini";
            this.lblini.Size = new System.Drawing.Size(13, 13);
            this.lblini.TabIndex = 11;
            this.lblini.Text = "0";
            // 
            // lblpChange
            // 
            this.lblpChange.AutoSize = true;
            this.lblpChange.Location = new System.Drawing.Point(826, 285);
            this.lblpChange.Name = "lblpChange";
            this.lblpChange.Size = new System.Drawing.Size(13, 13);
            this.lblpChange.TabIndex = 12;
            this.lblpChange.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "% Change:";
            // 
            // panOpt
            // 
            this.panOpt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panOpt.Location = new System.Drawing.Point(416, 39);
            this.panOpt.Name = "panOpt";
            this.panOpt.Size = new System.Drawing.Size(400, 400);
            this.panOpt.TabIndex = 1;
            this.panOpt.Paint += new System.Windows.Forms.PaintEventHandler(this.panOpt_Paint);
            // 
            // chkBoltz
            // 
            this.chkBoltz.AutoSize = true;
            this.chkBoltz.Location = new System.Drawing.Point(836, 403);
            this.chkBoltz.Name = "chkBoltz";
            this.chkBoltz.Size = new System.Drawing.Size(110, 17);
            this.chkBoltz.TabIndex = 14;
            this.chkBoltz.Text = "Enable Metropolis";
            this.chkBoltz.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Turns Left";
            // 
            // lblStale
            // 
            this.lblStale.AutoSize = true;
            this.lblStale.Location = new System.Drawing.Point(826, 330);
            this.lblStale.Name = "lblStale";
            this.lblStale.Size = new System.Drawing.Size(13, 13);
            this.lblStale.TabIndex = 16;
            this.lblStale.Text = "0";
            this.lblStale.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.Location = new System.Drawing.Point(826, 376);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(13, 13);
            this.lblTurns.TabIndex = 18;
            this.lblTurns.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(823, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Turns Taken";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Working Configuration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Optimized Configuration";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(836, 426);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(52, 23);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runMultipleSameMapToolStripMenuItem,
            this.chkARes});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // runMultipleSameMapToolStripMenuItem
            // 
            this.runMultipleSameMapToolStripMenuItem.Name = "runMultipleSameMapToolStripMenuItem";
            this.runMultipleSameMapToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.runMultipleSameMapToolStripMenuItem.Text = "Run Multiple (Same Map)";
            this.runMultipleSameMapToolStripMenuItem.Click += new System.EventHandler(this.runMultipleSameMapToolStripMenuItem_Click);
            // 
            // chkARes
            // 
            this.chkARes.CheckOnClick = true;
            this.chkARes.Name = "chkARes";
            this.chkARes.Size = new System.Drawing.Size(209, 22);
            this.chkARes.Text = "Auto Restart";
            // 
            // frmTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 468);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkBoltz);
            this.Controls.Add(this.panOpt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpChange);
            this.Controls.Add(this.lblini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.nudMaxS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCities);
            this.Controls.Add(this.nudCities);
            this.Controls.Add(this.panSales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTSP";
            this.Text = "Traveling Salesman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSales;
        private System.Windows.Forms.NumericUpDown nudCities;
        private System.Windows.Forms.Label lblCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaxS;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Timer timTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblini;
        private System.Windows.Forms.Label lblpChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panOpt;
        private System.Windows.Forms.CheckBox chkBoltz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStale;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runMultipleSameMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chkARes;
    }
}

