using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BykeFormsMyHomeTask
{
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you realy want to exit?", "Information",
               MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
