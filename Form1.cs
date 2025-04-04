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
            imgMineral.Image = Properties.Resources.Emerald;
            lblMineral.Text = "Emeralds are a very delicate gem. They are twenty times rarer than diamonds";
        }

        private void btnQuartz_Click(object sender, EventArgs e)
        {
            lblMineral.Visible = true;
            imgMineral.Image = Properties.Resources.Quartz;
            lblMineral.Text = "Quartz is the second most abundant mineral in the Earth's crust";
        }

        private void btnBismuth_Click(object sender, EventArgs e)
        {
            lblMineral.Visible = true;
            imgMineral.Image = Properties.Resources.Bismuth;
            lblMineral.Text = "Bismuth is the main ingredient in Pepto-Bismol. That's how Pepto got its name";
        }

       

        private void btnBismuthBear_MouseLeave(object sender, EventArgs e)
        {
            lblBear.Visible = false;
        }

        private void btnBismuthBear_Click(object sender, EventArgs e)
        {
            lblMineral.Visible = true;
            imgMineral.Image = Properties.Resources.Bismuth_bear_image;
            lblMineral.Text = "It's just a bear made of bismuth. A bismuth bear. He's a bit squished";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            imgMineral.Visible = false;
            lblMineral.Visible = false;
        }

        private void btnBismuthBear_MouseEnter(object sender, EventArgs e)
        {
            lblBear.Visible = true;
        }
    }
}
