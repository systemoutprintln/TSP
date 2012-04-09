using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Traveling_Salesman
{
    public partial class MultiSetup : Form
    {
        public double FMspeed;
        public double LMspeed;
        public MultiSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FMspeed = (double)nudFSpeed.Value;
            LMspeed = (double)nudLSpeed.Value;
            this.Hide();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
