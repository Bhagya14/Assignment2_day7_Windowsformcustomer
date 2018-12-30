using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form_Customer
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == string.Empty)
            {
                MessageBox.Show("Enter Login ID :");
            }
            else if (txt_password.Text == string.Empty)
            {
                MessageBox.Show("Enter Password :");
            }
            else
            {
                int loginid = Convert.ToInt32(txt_login.Text);
                string password = txt_password.Text;
                if (loginid == 1001 && password == "pass@123")
                {
                    MessageBox.Show("Valid User");
                    //frm_customer obj = new frm_customer();
                    //obj.Show();//open the new customer form
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
        }
    }
}
