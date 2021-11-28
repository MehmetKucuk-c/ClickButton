using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Degistir(Button Btn)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
            Btn.BackColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Degistir(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Degistir(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Degistir(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Degistir(button4);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello", "Hastahane", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
