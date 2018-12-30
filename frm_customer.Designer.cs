namespace Win_Form_Customer
{
    partial class frm_customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_customeremail = new System.Windows.Forms.Label();
            this.lbl_customername = new System.Windows.Forms.Label();
            this.lbl_customercity = new System.Windows.Forms.Label();
            this.lbl_customergender = new System.Windows.Forms.Label();
            this.txt_customeremail = new System.Windows.Forms.TextBox();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.cmb_customercity = new System.Windows.Forms.ComboBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_newcustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_customeremail
            // 
            this.lbl_customeremail.AutoSize = true;
            this.lbl_customeremail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_customeremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customeremail.Location = new System.Drawing.Point(43, 26);
            this.lbl_customeremail.Name = "lbl_customeremail";
            this.lbl_customeremail.Size = new System.Drawing.Size(185, 25);
            this.lbl_customeremail.TabIndex = 0;
            this.lbl_customeremail.Text = "Customer Email ID :";
            // 
            // lbl_customername
            // 
            this.lbl_customername.AutoSize = true;
            this.lbl_customername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_customername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customername.Location = new System.Drawing.Point(43, 83);
            this.lbl_customername.Name = "lbl_customername";
            this.lbl_customername.Size = new System.Drawing.Size(165, 25);
            this.lbl_customername.TabIndex = 1;
            this.lbl_customername.Text = "Customer Name :";
            // 
            // lbl_customercity
            // 
            this.lbl_customercity.AutoSize = true;
            this.lbl_customercity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_customercity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customercity.Location = new System.Drawing.Point(43, 129);
            this.lbl_customercity.Name = "lbl_customercity";
            this.lbl_customercity.Size = new System.Drawing.Size(147, 25);
            this.lbl_customercity.TabIndex = 2;
            this.lbl_customercity.Text = "Customer City :";
            // 
            // lbl_customergender
            // 
            this.lbl_customergender.AutoSize = true;
            this.lbl_customergender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_customergender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customergender.Location = new System.Drawing.Point(46, 186);
            this.lbl_customergender.Name = "lbl_customergender";
            this.lbl_customergender.Size = new System.Drawing.Size(178, 25);
            this.lbl_customergender.TabIndex = 3;
            this.lbl_customergender.Text = "Customer Gender :";
            // 
            // txt_customeremail
            // 
            this.txt_customeremail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_customeremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customeremail.Location = new System.Drawing.Point(371, 26);
            this.txt_customeremail.Name = "txt_customeremail";
            this.txt_customeremail.Size = new System.Drawing.Size(292, 30);
            this.txt_customeremail.TabIndex = 4;
            // 
            // txt_customername
            // 
            this.txt_customername.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_customername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customername.Location = new System.Drawing.Point(371, 83);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(292, 30);
            this.txt_customername.TabIndex = 5;
            // 
            // cmb_customercity
            // 
            this.cmb_customercity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmb_customercity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customercity.FormattingEnabled = true;
            this.cmb_customercity.Location = new System.Drawing.Point(371, 129);
            this.cmb_customercity.Name = "cmb_customercity";
            this.cmb_customercity.Size = new System.Drawing.Size(292, 33);
            this.cmb_customercity.TabIndex = 6;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rb_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(371, 181);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(76, 29);
            this.rb_male.TabIndex = 7;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = false;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rb_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.Location = new System.Drawing.Point(538, 186);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(98, 29);
            this.rb_female.TabIndex = 8;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = false;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(98, 326);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(122, 45);
            this.bt_login.TabIndex = 9;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_newcustomer
            // 
            this.bt_newcustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_newcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_newcustomer.Location = new System.Drawing.Point(564, 326);
            this.bt_newcustomer.Name = "bt_newcustomer";
            this.bt_newcustomer.Size = new System.Drawing.Size(164, 45);
            this.bt_newcustomer.TabIndex = 10;
            this.bt_newcustomer.Text = "New Customer";
            this.bt_newcustomer.UseVisualStyleBackColor = false;
            this.bt_newcustomer.Click += new System.EventHandler(this.bt_newcustomer_Click);
            // 
            // frm_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 455);
            this.Controls.Add(this.bt_newcustomer);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.cmb_customercity);
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.txt_customeremail);
            this.Controls.Add(this.lbl_customergender);
            this.Controls.Add(this.lbl_customercity);
            this.Controls.Add(this.lbl_customername);
            this.Controls.Add(this.lbl_customeremail);
            this.Name = "frm_customer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customeremail;
        private System.Windows.Forms.Label lbl_customername;
        private System.Windows.Forms.Label lbl_customercity;
        private System.Windows.Forms.Label lbl_customergender;
        private System.Windows.Forms.TextBox txt_customeremail;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.ComboBox cmb_customercity;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_newcustomer;
    }
}

