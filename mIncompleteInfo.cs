using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiant_Luxe_Kafe
{
    public partial class mIncompleteInfo : Form
    {
        public mIncompleteInfo()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gbtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
