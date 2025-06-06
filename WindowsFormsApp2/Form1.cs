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
        public class AppUsers
        {
            private string login;
            private string password;

            public string getLogin()
            {
                return login;
            }
            public String getPassword()
            {
                return password;
            }

            public void setLogin(String login)
            {
                this.login = login;
            }

            public void setPassword(String password)
            {
                this.password = password;
            }

            public AppUsers setLoginAndPassword(String login, String password)
            {
                this.login = login;
                this.password = password;
                return this;
            }
        }



        public Form1()
        {
            InitializeComponent();

        }

        static AppUsers users1 = new AppUsers().setLoginAndPassword("user1", "user1");
        static AppUsers users2 = new AppUsers().setLoginAndPassword("user2", "user2");
        static AppUsers users3 = new AppUsers().setLoginAndPassword("user3", "user3");

        static List<AppUsers> userList = new List<AppUsers> { users1, users2, users3 };

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

        private void button1_Click(object sender, EventArgs e)
        {
            AppUsers users1 = new AppUsers().setLoginAndPassword("user1", "user1");
            AppUsers users2 = new AppUsers().setLoginAndPassword("user2", "user2");
            AppUsers users3 = new AppUsers().setLoginAndPassword("user3", "user3");

            List<AppUsers> userList = new List<AppUsers> { users1, users2, users3 };

            bool loginChecking = false;

            for (int i = 0; i < userList.Count; i++)
            {
                AppUsers user = userList[i];
                String login = user.getLogin();
                String password = user.getPassword();
                if (login == textBox1.Text && password == textBox2.Text)
                {
                    loginChecking = true;
                }
            }

                if (loginChecking)
                {
                    Form2 form2 = new Form2(this);
                    form2.ShowDialog();
                    
            }
                else
                {
                    MessageBox.Show("Wrong login or password!");
                }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
