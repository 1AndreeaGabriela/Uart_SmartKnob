using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnobApp
{
    public partial class ComboBoxWithButton : UserControl
    {
        public ComboBoxWithButton()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialMultiLineTextBox1.Clear();
        }

        private void materialMultiLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
