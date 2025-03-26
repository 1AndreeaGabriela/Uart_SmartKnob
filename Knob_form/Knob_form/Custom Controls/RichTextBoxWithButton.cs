using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knob_form
{
    public partial class RichTextBoxWithButton : UserControl
    {
        public RichTextBoxWithButton()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void materialButtonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
