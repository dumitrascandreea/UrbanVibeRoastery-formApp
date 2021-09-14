
namespace UrbanVibeRoastery
{
    partial class CustomerOrder
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
            this.lbEuro = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.DataGridView();
            this.brnLogin = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtGuest = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.ProductsView = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.pnBeans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBeans
            // 
            this.pnBeans.BackgroundImage = global::UrbanVibeRoastery.Properties.Resources.beans;
            this.pnBeans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBeans.Controls.Add(this.lbEuro);
            this.pnBeans.Controls.Add(this.txtQty);
            this.pnBeans.Controls.Add(this.label3);
            this.pnBeans.Controls.Add(this.button1);
            this.pnBeans.Controls.Add(this.cart);
            this.pnBeans.Controls.Add(this.brnLogin);
            this.pnBeans.Controls.Add(this.lbTotal);
            this.pnBeans.Controls.Add(this.txtGuest);
            this.pnBeans.Controls.Add(this.txtOrderNumber);
            this.pnBeans.Controls.Add(this.ProductsView);
            this.pnBeans.Controls.Add(this.cbCategory);
            this.pnBeans.Controls.Add(this.lbUser);
            this.pnBeans.Location = new System.Drawing.Point(162, 5);
            this.pnBeans.Name = "pnBeans";
            this.pnBeans.Size = new System.Drawing.Size(669, 502);
            this.pnBeans.TabIndex = 0;
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.BackColor = System.Drawing.Color.Transparent;
            this.lbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEuro.Location = new System.Drawing.Point(404, 468);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(64, 29);
            this.lbEuro.TabIndex = 15;
            this.lbEuro.Text = "Euro";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(18, 132);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(170, 26);
            this.txtQty.TabIndex = 14;
            this.txtQty.Text = "Qunatity";
            this.txtQty.Click += new System.EventHandler(this.txtQty_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your Cart";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cart
            // 
            this.cart.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart.Location = new System.Drawing.Point(94, 310);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(512, 150);
            this.cart.TabIndex = 11;
            // 
            // brnLogin
            // 
            this.brnLogin.BackColor = System.Drawing.Color.PeachPuff;
            this.brnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnLogin.Location = new System.Drawing.Point(18, 165);
            this.brnLogin.Name = "brnLogin";
            this.brnLogin.Size = new System.Drawing.Size(170, 34);
            this.brnLogin.TabIndex = 10;
            this.brnLogin.Text = "Add to Cart";
            this.brnLogin.UseVisualStyleBackColor = false;
            this.brnLogin.Click += new System.EventHandler(this.brnLogin_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(474, 468);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(68, 29);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Total";
            // 
            // txtGuest
            // 
            this.txtGuest.Enabled = false;
            this.txtGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuest.Location = new System.Drawing.Point(18, 100);
            this.txtGuest.Name = "txtGuest";
            this.txtGuest.Size = new System.Drawing.Size(170, 26);
            this.txtGuest.TabIndex = 8;
            this.txtGuest.Text = "Guest";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(18, 68);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(170, 26);
            this.txtOrderNumber.TabIndex = 7;
            this.txtOrderNumber.Text = "OrderNumber";
            this.txtOrderNumber.Click += new System.EventHandler(this.txtOrderNumber_Click);
            // 
            // ProductsView
            // 
            this.ProductsView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductsView.Location = new System.Drawing.Point(207, 36);
            this.ProductsView.Name = "ProductsView";
            this.ProductsView.ReadOnly = true;
            this.ProductsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsView.Size = new System.Drawing.Size(462, 163);
            this.ProductsView.TabIndex = 6;
            this.ProductsView.Tag = "0";
            this.ProductsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsView_CellClick);
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
            this.cbCategory.Location = new System.Drawing.Point(18, 36);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(170, 26);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.Text = "Category";
            this.cbCategory.SelectionChangeCommitted += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(281, 4);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(170, 29);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "Place an order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(36, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "LogOut";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbClose.Location = new System.Drawing.Point(807, 5);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 24);
            this.lbClose.TabIndex = 9;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UrbanVibeRoastery.Properties.Resources.afrah_Qwiwjf3oZ1U_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 508);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnBeans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            this.pnBeans.ResumeLayout(false);
            this.pnBeans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBeans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtGuest;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.DataGridView ProductsView;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cart;
        private System.Windows.Forms.Button brnLogin;
        private System.Windows.Forms.Label lbEuro;
    }
}