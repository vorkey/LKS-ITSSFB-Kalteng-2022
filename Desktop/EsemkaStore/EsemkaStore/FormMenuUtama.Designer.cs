namespace EsemkaStore
{
    partial class FormMenuUtama
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
            this.BtnManageProduct = new System.Windows.Forms.Button();
            this.BtnManageUser = new System.Windows.Forms.Button();
            this.BtnAddTransaction = new System.Windows.Forms.Button();
            this.BtnViewTransaction = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnManageProduct
            // 
            this.BtnManageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.BtnManageProduct.ForeColor = System.Drawing.Color.White;
            this.BtnManageProduct.Location = new System.Drawing.Point(68, 124);
            this.BtnManageProduct.Name = "BtnManageProduct";
            this.BtnManageProduct.Size = new System.Drawing.Size(140, 45);
            this.BtnManageProduct.TabIndex = 0;
            this.BtnManageProduct.Text = "Manage Product";
            this.BtnManageProduct.UseVisualStyleBackColor = false;
            this.BtnManageProduct.Click += new System.EventHandler(this.BtnManageProduct_Click);
            // 
            // BtnManageUser
            // 
            this.BtnManageUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.BtnManageUser.ForeColor = System.Drawing.Color.White;
            this.BtnManageUser.Location = new System.Drawing.Point(68, 176);
            this.BtnManageUser.Name = "BtnManageUser";
            this.BtnManageUser.Size = new System.Drawing.Size(140, 45);
            this.BtnManageUser.TabIndex = 1;
            this.BtnManageUser.Text = "Manage User";
            this.BtnManageUser.UseVisualStyleBackColor = false;
            this.BtnManageUser.Click += new System.EventHandler(this.BtnManageUser_Click);
            // 
            // BtnAddTransaction
            // 
            this.BtnAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.BtnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.BtnAddTransaction.Location = new System.Drawing.Point(68, 228);
            this.BtnAddTransaction.Name = "BtnAddTransaction";
            this.BtnAddTransaction.Size = new System.Drawing.Size(140, 45);
            this.BtnAddTransaction.TabIndex = 2;
            this.BtnAddTransaction.Text = "Add Transaction";
            this.BtnAddTransaction.UseVisualStyleBackColor = false;
            this.BtnAddTransaction.Click += new System.EventHandler(this.BtnAddTransaction_Click);
            // 
            // BtnViewTransaction
            // 
            this.BtnViewTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(99)))));
            this.BtnViewTransaction.ForeColor = System.Drawing.Color.White;
            this.BtnViewTransaction.Location = new System.Drawing.Point(68, 280);
            this.BtnViewTransaction.Name = "BtnViewTransaction";
            this.BtnViewTransaction.Size = new System.Drawing.Size(140, 45);
            this.BtnViewTransaction.TabIndex = 3;
            this.BtnViewTransaction.Text = "View Transaction";
            this.BtnViewTransaction.UseVisualStyleBackColor = false;
            this.BtnViewTransaction.Click += new System.EventHandler(this.BtnViewTransaction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EsemkaStore.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(54, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(277, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnViewTransaction);
            this.Controls.Add(this.BtnAddTransaction);
            this.Controls.Add(this.BtnManageUser);
            this.Controls.Add(this.BtnManageProduct);
            this.Name = "FormMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EsemkaStore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnManageProduct;
        private System.Windows.Forms.Button BtnManageUser;
        private System.Windows.Forms.Button BtnAddTransaction;
        private System.Windows.Forms.Button BtnViewTransaction;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}