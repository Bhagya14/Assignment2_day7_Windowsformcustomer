namespace Win_Form_Customer
{
    partial class frm_NewOrder
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
            this.lbl_customerid = new System.Windows.Forms.Label();
            this.lbl_itemname = new System.Windows.Forms.Label();
            this.lbl_itemprice = new System.Windows.Forms.Label();
            this.lbl_itemquantity = new System.Windows.Forms.Label();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_itemprice = new System.Windows.Forms.TextBox();
            this.txt_itemquantity = new System.Windows.Forms.TextBox();
            this.bt_neworder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_customerid
            // 
            this.lbl_customerid.AutoSize = true;
            this.lbl_customerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerid.Location = new System.Drawing.Point(55, 57);
            this.lbl_customerid.Name = "lbl_customerid";
            this.lbl_customerid.Size = new System.Drawing.Size(132, 25);
            this.lbl_customerid.TabIndex = 0;
            this.lbl_customerid.Text = "Customer ID :";
            // 
            // lbl_itemname
            // 
            this.lbl_itemname.AutoSize = true;
            this.lbl_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemname.Location = new System.Drawing.Point(55, 117);
            this.lbl_itemname.Name = "lbl_itemname";
            this.lbl_itemname.Size = new System.Drawing.Size(117, 25);
            this.lbl_itemname.TabIndex = 1;
            this.lbl_itemname.Text = "Item Name :";
            // 
            // lbl_itemprice
            // 
            this.lbl_itemprice.AutoSize = true;
            this.lbl_itemprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemprice.Location = new System.Drawing.Point(55, 182);
            this.lbl_itemprice.Name = "lbl_itemprice";
            this.lbl_itemprice.Size = new System.Drawing.Size(109, 25);
            this.lbl_itemprice.TabIndex = 2;
            this.lbl_itemprice.Text = "Item Price :";
            // 
            // lbl_itemquantity
            // 
            this.lbl_itemquantity.AutoSize = true;
            this.lbl_itemquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemquantity.Location = new System.Drawing.Point(55, 249);
            this.lbl_itemquantity.Name = "lbl_itemquantity";
            this.lbl_itemquantity.Size = new System.Drawing.Size(138, 25);
            this.lbl_itemquantity.TabIndex = 3;
            this.lbl_itemquantity.Text = "Item Quantity :";
            // 
            // txt_customerid
            // 
            this.txt_customerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerid.Location = new System.Drawing.Point(280, 57);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(332, 30);
            this.txt_customerid.TabIndex = 4;
            // 
            // txt_itemname
            // 
            this.txt_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemname.Location = new System.Drawing.Point(280, 117);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(332, 30);
            this.txt_itemname.TabIndex = 5;
            // 
            // txt_itemprice
            // 
            this.txt_itemprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemprice.Location = new System.Drawing.Point(280, 176);
            this.txt_itemprice.Name = "txt_itemprice";
            this.txt_itemprice.Size = new System.Drawing.Size(332, 30);
            this.txt_itemprice.TabIndex = 6;
            // 
            // txt_itemquantity
            // 
            this.txt_itemquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemquantity.Location = new System.Drawing.Point(280, 249);
            this.txt_itemquantity.Name = "txt_itemquantity";
            this.txt_itemquantity.Size = new System.Drawing.Size(332, 30);
            this.txt_itemquantity.TabIndex = 7;
            // 
            // bt_neworder
            // 
            this.bt_neworder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_neworder.Location = new System.Drawing.Point(341, 360);
            this.bt_neworder.Name = "bt_neworder";
            this.bt_neworder.Size = new System.Drawing.Size(138, 62);
            this.bt_neworder.TabIndex = 8;
            this.bt_neworder.Text = "New Order ";
            this.bt_neworder.UseVisualStyleBackColor = true;
            // 
            // frm_NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(854, 495);
            this.Controls.Add(this.bt_neworder);
            this.Controls.Add(this.txt_itemquantity);
            this.Controls.Add(this.txt_itemprice);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(this.lbl_itemquantity);
            this.Controls.Add(this.lbl_itemprice);
            this.Controls.Add(this.lbl_itemname);
            this.Controls.Add(this.lbl_customerid);
            this.Name = "frm_NewOrder";
            this.Text = "frm_NewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customerid;
        private System.Windows.Forms.Label lbl_itemname;
        private System.Windows.Forms.Label lbl_itemprice;
        private System.Windows.Forms.Label lbl_itemquantity;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.TextBox txt_itemprice;
        private System.Windows.Forms.TextBox txt_itemquantity;
        private System.Windows.Forms.Button bt_neworder;
    }
}