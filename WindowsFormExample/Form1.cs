using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBold_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBoldItalic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnItalic_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStrikeThru_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStrikeThru.Checked == true)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Strikeout);
            }
            else if (btnStrikeThru.Checked == false)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
            }
        }

        private void groupEffect_Enter(object sender, EventArgs e)
        {

        }

        private void groupStyle_Enter(object sender, EventArgs e)
        {

        }

        private void btnUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (btnUnderline.Checked == true && btnStrikeThru.Checked == true)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Underline);
                textBox1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Strikeout);
            }
            if (btnUnderline.Checked == true)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Underline);
            }
            else if (btnUnderline.Checked == false)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
            }
        }
    }
}
