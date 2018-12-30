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
    public partial class frm_customer : Form
    {
        public frm_customer()
        {
            InitializeComponent();
        }

        private void bt_newcustomer_Click(object sender, EventArgs e)
        {
            if(txt_customeremail.Text==string.Empty)
            {
                MessageBox.Show("Enter Customer Email ID :");
            }
            else if (txt_customername.Text == string.Empty)
            {
                MessageBox.Show("Enter Customer Name :");
            }
            else if (cmb_customercity.Text == string.Empty)
            {
                MessageBox.Show("Select City");
            }
            else if (rb_male.Checked == false && rb_female.Checked == false)
            {
                MessageBox.Show("Select Gender");
            }
            else
            {
                string customeremailid = txt_customeremail.Text;
                string customername = txt_customername.Text;
                string customercity = cmb_customercity.Text;
                string customergender = string.Empty;
                if (rb_male.Checked)
                {
                    customergender = "Male";
                }
                else
                {
                    customergender = "Female";
                }
                MessageBox.Show("Customer Created");
            }
        }

        private void frm_customer_Load(object sender, EventArgs e)
        {
            cmb_customercity.Items.Add("BGL");
            cmb_customercity.Items.Add("Pune");
            cmb_customercity.Items.Add("Chennai");
            cmb_customercity.Items.Add("AP");
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
        }
    }
}

