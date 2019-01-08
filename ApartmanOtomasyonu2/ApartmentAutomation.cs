using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonu2
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnIcomes_Click(object sender, EventArgs e)
        {
            new Operations().Show();
            this.Visible = false;
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Operations f = new Operations();
            f.SelectTab();
            f.Show();
            this.Visible = false;
        }
    }
}
