namespace ABCLimitedorderform
{
    partial class Form1
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
            this.tblOrderNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblCustomerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tblProductName = new System.Windows.Forms.TextBox();
            this.TblPrice = new System.Windows.Forms.TextBox();
            this.TblQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LbList = new System.Windows.Forms.ListBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tblOrderNo
            // 
            this.tblOrderNo.Location = new System.Drawing.Point(121, 64);
            this.tblOrderNo.Name = "tblOrderNo";
            this.tblOrderNo.Size = new System.Drawing.Size(100, 20);
            this.tblOrderNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order no";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tblCustomerId
            // 
            this.tblCustomerId.Location = new System.Drawing.Point(121, 103);
            this.tblCustomerId.Name = "tblCustomerId";
            this.tblCustomerId.Size = new System.Drawing.Size(100, 20);
            this.tblCustomerId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(-1, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(44, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(44, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tblProductName
            // 
            this.tblProductName.Location = new System.Drawing.Point(121, 135);
            this.tblProductName.Name = "tblProductName";
            this.tblProductName.Size = new System.Drawing.Size(100, 20);
            this.tblProductName.TabIndex = 8;
            // 
            // TblPrice
            // 
            this.TblPrice.Location = new System.Drawing.Point(121, 165);
            this.TblPrice.Name = "TblPrice";
            this.TblPrice.Size = new System.Drawing.Size(100, 20);
            this.TblPrice.TabIndex = 9;
            // 
            // TblQuantity
            // 
            this.TblQuantity.Location = new System.Drawing.Point(121, 194);
            this.TblQuantity.Name = "TblQuantity";
            this.TblQuantity.Size = new System.Drawing.Size(100, 20);
            this.TblQuantity.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(97, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "£";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // LbList
            // 
            this.LbList.FormattingEnabled = true;
            this.LbList.Location = new System.Drawing.Point(337, 58);
            this.LbList.Name = "LbList";
            this.LbList.Size = new System.Drawing.Size(208, 264);
            this.LbList.TabIndex = 12;
            this.LbList.SelectedIndexChanged += new System.EventHandler(this.LbList_SelectedIndexChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(387, 329);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(387, 359);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 14;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.LbList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TblQuantity);
            this.Controls.Add(this.TblPrice);
            this.Controls.Add(this.tblProductName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblCustomerId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblOrderNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblOrderNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tblCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tblProductName;
        private System.Windows.Forms.TextBox TblPrice;
        private System.Windows.Forms.TextBox TblQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox LbList;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button bt_Delete;
    }
}

