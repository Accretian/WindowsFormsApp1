using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "Login must contain latin letters and/or digits.");
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "");
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(textBox2, "Password must contain latin letters and/or digits.");
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(textBox2, "");
        }

        private void showClick(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        
    } 
}
