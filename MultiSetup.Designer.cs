namespace Traveling_Salesman
{
    partial class MultiSetup
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
            this.nudFSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFSpeed
            // 
            this.nudFSpeed.Location = new System.Drawing.Point(105, 7);
            this.nudFSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFSpeed.Name = "nudFSpeed";
            this.nudFSpeed.Size = new System.Drawing.Size(120, 20);
            this.nudFSpeed.TabIndex = 0;
            this.nudFSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Max Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Max Speed";
            // 
            // nudLSpeed
            // 
            this.nudLSpeed.Location = new System.Drawing.Point(105, 33);
            this.nudLSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLSpeed.Name = "nudLSpeed";
            this.nudLSpeed.Size = new System.Drawing.Size(120, 20);
            this.nudLSpeed.TabIndex = 3;
            this.nudLSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLSpeed.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(266, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MultiSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 101);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudLSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFSpeed);
            this.Name = "MultiSetup";
            this.Text = "MultiSetup";
            ((System.ComponentModel.ISupportInitialize)(this.nudFSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLSpeed;
        private System.Windows.Forms.Button btnSave;
    }
}