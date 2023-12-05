using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivary.PARENT_FORMS
{
    public partial class FORM_REPORTS : Form
    {
        public FORM_REPORTS()
        {
            InitializeComponent();
        }

        private void roundedTextBox1_Enter(object sender, EventArgs e)
        {
            if(roundedTextBox1.Text == "unfair")
            {
                roundedTextBox1.Text = string.Empty;
            }
        }
    }
}
