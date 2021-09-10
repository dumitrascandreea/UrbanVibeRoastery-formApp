﻿
namespace UrbanVibeRoastery
{
    partial class Products
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
            this.pnBeans = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.brnLogin = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnBeans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBeans
            // 
            this.pnBeans.BackgroundImage = global::UrbanVibeRoastery.Properties.Resources.beans;
            this.pnBeans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBeans.Controls.Add(this.button4);
            this.pnBeans.Controls.Add(this.button1);
            this.pnBeans.Controls.Add(this.label4);
            this.pnBeans.Controls.Add(this.label2);
            this.pnBeans.Controls.Add(this.lbNum);
            this.pnBeans.Controls.Add(this.lbClose);
            this.pnBeans.Controls.Add(this.txtPrice);
            this.pnBeans.Controls.Add(this.brnLogin);
            this.pnBeans.Controls.Add(this.txtItemName);
            this.pnBeans.Controls.Add(this.txtNumber);
            this.pnBeans.Controls.Add(this.ProductsView);
            this.pnBeans.Controls.Add(this.cbCategory);
            this.pnBeans.Controls.Add(this.lbUser);
            this.pnBeans.Location = new System.Drawing.Point(159, 3);
            this.pnBeans.Name = "pnBeans";
            this.pnBeans.Size = new System.Drawing.Size(670, 502);
            this.pnBeans.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(85, 167);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(116, 19);
            this.txtPrice.TabIndex = 14;
            // 
            // brnLogin
            // 
            this.brnLogin.BackColor = System.Drawing.Color.PeachPuff;
            this.brnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnLogin.Location = new System.Drawing.Point(18, 201);
            this.brnLogin.Name = "brnLogin";
            this.brnLogin.Size = new System.Drawing.Size(130, 34);
            this.brnLogin.TabIndex = 10;
            this.brnLogin.Text = "Add";
            this.brnLogin.UseVisualStyleBackColor = false;
            this.brnLogin.Click += new System.EventHandler(this.brnLogin_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(85, 137);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(116, 19);
            this.txtItemName.TabIndex = 8;
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(85, 108);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(116, 19);
            this.txtNumber.TabIndex = 7;
            // 
            // ProductsView
            // 
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.Location = new System.Drawing.Point(207, 36);
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.Size = new System.Drawing.Size(462, 424);
            this.ProductsView.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Coffee",
            "Tea",
            "Beverages",
            "Cakes"});
            this.cbCategory.Location = new System.Drawing.Point(18, 68);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(183, 26);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.Text = "Category";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(337, 4);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(108, 29);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "Products";
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbClose.Location = new System.Drawing.Point(643, 6);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 24);
            this.lbClose.TabIndex = 15;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Users";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.BackColor = System.Drawing.Color.Transparent;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum.Location = new System.Drawing.Point(14, 108);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(65, 20);
            this.lbNum.TabIndex = 16;
            this.lbNum.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 34);
            this.button4.TabIndex = 20;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UrbanVibeRoastery.Properties.Resources.afrah_Qwiwjf3oZ1U_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 508);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnBeans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.pnBeans.ResumeLayout(false);
            this.pnBeans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBeans;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button brnLogin;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DataGridView ProductsView;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}