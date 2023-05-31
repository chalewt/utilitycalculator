using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilityCalculator
{
    public partial class MainMdi : Form
    {
        public MainMdi()
        {
            InitializeComponent();
        }

        private void electricityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Electricity elec = new Electricity();
            elec.MdiParent = this;
            elec.Show();
        }
    }
}
