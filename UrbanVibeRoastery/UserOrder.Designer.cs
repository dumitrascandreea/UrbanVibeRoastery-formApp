
namespace UrbanVibeRoastery
{
    partial class UserOrder
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
            this.lbClose = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.DataGridView();
            this.brnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NumberProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnBeans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBeans
            // 
            this.pnBeans.BackgroundImage = global::UrbanVibeRoastery.Properties.Resources.beans;
            this.pnBeans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBeans.Controls.Add(this.lbClose);
            this.pnBeans.Controls.Add(this.txtQty);
            this.pnBeans.Controls.Add(this.label3);
            this.pnBeans.Controls.Add(this.button1);
            this.pnBeans.Controls.Add(this.cart);
            this.pnBeans.Controls.Add(this.brnLogin);
            this.pnBeans.Controls.Add(this.label1);
            this.pnBeans.Controls.Add(this.txtUser);
            this.pnBeans.Controls.Add(this.txtOrder);
            this.pnBeans.Controls.Add(this.OrderView);
            this.pnBeans.Controls.Add(this.cbCategory);
            this.pnBeans.Controls.Add(this.lbUser);
            this.pnBeans.Location = new System.Drawing.Point(134, 2);
            this.pnBeans.Name = "pnBeans";
            this.pnBeans.Size = new System.Drawing.Size(698, 502);
            this.pnBeans.TabIndex = 1;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbClose.Location = new System.Drawing.Point(660, 7);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 24);
            this.lbClose.TabIndex = 15;
            this.lbClose.Text = "X";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(18, 132);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(170, 26);
            this.txtQty.TabIndex = 14;
            this.txtQty.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your Cart";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(207, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cart
            // 
            this.cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberProduct,
            this.ProdName,
            this.Category,
            this.UnitPrice,
            this.TotalAmont});
            this.cart.Location = new System.Drawing.Point(207, 312);
            this.cart.MultiSelect = false;
            this.cart.Name = "cart";
            this.cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cart.Size = new System.Drawing.Size(488, 150);
            this.cart.TabIndex = 11;
            this.cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(18, 100);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(170, 26);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "Customer";
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrder.Location = new System.Drawing.Point(18, 68);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(170, 26);
            this.txtOrder.TabIndex = 7;
            this.txtOrder.Text = "OrderNumber";
            // 
            // OrderView
            // 
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Location = new System.Drawing.Point(207, 36);
            this.OrderView.Name = "OrderView";
            this.OrderView.Size = new System.Drawing.Size(491, 163);
            this.OrderView.TabIndex = 6;
         
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
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(239, 4);
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
            this.label2.Location = new System.Drawing.Point(12, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "LogOut";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 14;
            this.button3.Text = "Users";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NumberProduct
            // 
            this.NumberProduct.HeaderText = "Number";
            this.NumberProduct.Name = "NumberProduct";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProductName";
            this.ProdName.Name = "ProdName";
            // 
            // Category
            // 
            this.Category.HeaderText = "Cateory";
            this.Category.Name = "Category";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalAmont
            // 
            this.TotalAmont.HeaderText = "Total";
            this.TotalAmont.Name = "TotalAmont";
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UrbanVibeRoastery.Properties.Resources.afrah_Qwiwjf3oZ1U_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 508);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnBeans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOrdercs";
            this.Load += new System.EventHandler(this.UserOrder_Load);
            this.pnBeans.ResumeLayout(false);
            this.pnBeans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBeans;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button brnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.DataGridView OrderView;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmont;
    }
}