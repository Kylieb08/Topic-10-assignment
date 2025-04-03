using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10_assignment
{
    public partial class FormAddingResourcesAssignment : Form
    {
        public FormAddingResourcesAssignment()
        {
            InitializeComponent();
        }

        private void btnEmerald_Click(object sender, EventArgs e)
        {
            lblMineral.Visible = true;
            lblMineral.Text = "Emeralds are a very delicate gem. They are twenty times rarer than diamonds";
        }

        private void btnQuartz_Click(object sender, EventArgs e)
        {
            lblMineral.Visible = true;
            lblMineral.Text = "Quartz is the second most abundant mineral in the Earth's crust";
        }

        private void btnBismuth_Click(object sender, EventArgs e)
        {
            lblMineral.Visible = true;
            lblMineral.Text = "Bismuth is the main ingredient in Pepto-Bismol. That's how Pepto got its name";
        }
    }
}
