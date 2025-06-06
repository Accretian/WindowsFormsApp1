using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private static Form1 f1;

        public Form2(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        protected override void OnClosed(EventArgs e)
        {
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            f1.Hide();
        }



        
    }
}
