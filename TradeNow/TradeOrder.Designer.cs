namespace TradeNow
{
    partial class TradeOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Routes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.symbolbs = new System.Windows.Forms.Label();
            this.quantitybs = new System.Windows.Forms.Label();
            this.pricebs = new System.Windows.Forms.Label();
            this.routebs = new System.Windows.Forms.Label();
            this.orderbs = new System.Windows.Forms.Label();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.routeBox = new System.Windows.Forms.ComboBox();
            this.createOrder = new System.Windows.Forms.Button();
            this.ordertypebs = new System.Windows.Forms.Label();
            this.tifbs = new System.Windows.Forms.Label();
            this.ordertypeBox = new System.Windows.Forms.ComboBox();
            this.tifBox = new System.Windows.Forms.ComboBox();
            this.orderID = new System.Windows.Forms.Label();
            this.orderIDbox = new System.Windows.Forms.TextBox();
            this.NewOrder = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 433);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OrderID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Order";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Route";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "OrderType";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TiF";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            // 
            // TiF
            // 
            this.TiF.HeaderText = "TiF";
            this.TiF.Name = "TiF";
            // 
            // Routes
            // 
            this.Routes.HeaderText = "Routes";
            this.Routes.Name = "Routes";
            // 
            // symbolBox
            // 
            this.symbolBox.Location = new System.Drawing.Point(317, 122);
            this.symbolBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.symbolBox.Name = "symbolBox";
            this.symbolBox.Size = new System.Drawing.Size(146, 29);
            this.symbolBox.TabIndex = 2;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(317, 243);
            this.priceBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(146, 29);
            this.priceBox.TabIndex = 4;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(317, 182);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(146, 29);
            this.quantityBox.TabIndex = 3;
            // 
            // symbolbs
            // 
            this.symbolbs.AutoSize = true;
            this.symbolbs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symbolbs.Location = new System.Drawing.Point(136, 125);
            this.symbolbs.Name = "symbolbs";
            this.symbolbs.Size = new System.Drawing.Size(61, 23);
            this.symbolbs.TabIndex = 6;
            this.symbolbs.Text = "Symbol";
            // 
            // quantitybs
            // 
            this.quantitybs.AutoSize = true;
            this.quantitybs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantitybs.Location = new System.Drawing.Point(136, 185);
            this.quantitybs.Name = "quantitybs";
            this.quantitybs.Size = new System.Drawing.Size(65, 23);
            this.quantitybs.TabIndex = 7;
            this.quantitybs.Text = "Quantity";
            // 
            // pricebs
            // 
            this.pricebs.AutoSize = true;
            this.pricebs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricebs.Location = new System.Drawing.Point(136, 246);
            this.pricebs.Name = "pricebs";
            this.pricebs.Size = new System.Drawing.Size(45, 23);
            this.pricebs.TabIndex = 8;
            this.pricebs.Text = "Price";
            // 
            // routebs
            // 
            this.routebs.AutoSize = true;
            this.routebs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.routebs.Location = new System.Drawing.Point(136, 306);
            this.routebs.Name = "routebs";
            this.routebs.Size = new System.Drawing.Size(51, 23);
            this.routebs.TabIndex = 9;
            this.routebs.Text = "Route";
            // 
            // orderbs
            // 
            this.orderbs.AutoSize = true;
            this.orderbs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderbs.Location = new System.Drawing.Point(136, 69);
            this.orderbs.Name = "orderbs";
            this.orderbs.Size = new System.Drawing.Size(50, 23);
            this.orderbs.TabIndex = 14;
            this.orderbs.Text = "Order";
            // 
            // orderBox
            // 
            this.orderBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Items.AddRange(new object[] {
            "BUY",
            "SELL",
            "SHORT"});
            this.orderBox.Location = new System.Drawing.Point(317, 66);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(146, 30);
            this.orderBox.TabIndex = 1;
            // 
            // routeBox
            // 
            this.routeBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.routeBox.FormattingEnabled = true;
            this.routeBox.Items.AddRange(new object[] {
            "ARCA",
            "NYSE",
            "NASDAQ",
            "ATS",
            "KSE",
            "PSEX"});
            this.routeBox.Location = new System.Drawing.Point(317, 304);
            this.routeBox.Name = "routeBox";
            this.routeBox.Size = new System.Drawing.Size(146, 30);
            this.routeBox.TabIndex = 5;
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(567, 288);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(146, 41);
            this.createOrder.TabIndex = 8;
            this.createOrder.Text = "Create Order";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // ordertypebs
            // 
            this.ordertypebs.AutoSize = true;
            this.ordertypebs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordertypebs.Location = new System.Drawing.Point(567, 72);
            this.ordertypebs.Name = "ordertypebs";
            this.ordertypebs.Size = new System.Drawing.Size(88, 23);
            this.ordertypebs.TabIndex = 10;
            this.ordertypebs.Text = "Order Type";
            // 
            // tifbs
            // 
            this.tifbs.AutoSize = true;
            this.tifbs.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tifbs.Location = new System.Drawing.Point(567, 127);
            this.tifbs.Name = "tifbs";
            this.tifbs.Size = new System.Drawing.Size(32, 23);
            this.tifbs.TabIndex = 12;
            this.tifbs.Text = "TiF";
            // 
            // ordertypeBox
            // 
            this.ordertypeBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordertypeBox.FormattingEnabled = true;
            this.ordertypeBox.Items.AddRange(new object[] {
            "MKT",
            "LMT",
            "STOP LMT",
            "BUY LMT",
            "SEL LMT"});
            this.ordertypeBox.Location = new System.Drawing.Point(748, 70);
            this.ordertypeBox.Name = "ordertypeBox";
            this.ordertypeBox.Size = new System.Drawing.Size(146, 30);
            this.ordertypeBox.TabIndex = 6;
            // 
            // tifBox
            // 
            this.tifBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tifBox.FormattingEnabled = true;
            this.tifBox.Items.AddRange(new object[] {
            "DAY",
            "GTC"});
            this.tifBox.Location = new System.Drawing.Point(748, 123);
            this.tifBox.Name = "tifBox";
            this.tifBox.Size = new System.Drawing.Size(146, 30);
            this.tifBox.TabIndex = 7;
            // 
            // orderID
            // 
            this.orderID.AutoSize = true;
            this.orderID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderID.Location = new System.Drawing.Point(567, 187);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(68, 23);
            this.orderID.TabIndex = 20;
            this.orderID.Text = "Order ID";
            // 
            // orderIDbox
            // 
            this.orderIDbox.Location = new System.Drawing.Point(748, 184);
            this.orderIDbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderIDbox.Name = "orderIDbox";
            this.orderIDbox.ReadOnly = true;
            this.orderIDbox.Size = new System.Drawing.Size(146, 29);
            this.orderIDbox.TabIndex = 21;
            this.orderIDbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // NewOrder
            // 
            this.NewOrder.Location = new System.Drawing.Point(748, 288);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(146, 41);
            this.NewOrder.TabIndex = 10;
            this.NewOrder.Text = "New Order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(958, 21);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(74, 32);
            this.logout.TabIndex = 22;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // TradeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 827);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.orderIDbox);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.routeBox);
            this.Controls.Add(this.tifBox);
            this.Controls.Add(this.ordertypeBox);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.orderbs);
            this.Controls.Add(this.tifbs);
            this.Controls.Add(this.ordertypebs);
            this.Controls.Add(this.routebs);
            this.Controls.Add(this.pricebs);
            this.Controls.Add(this.quantitybs);
            this.Controls.Add(this.symbolbs);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.symbolBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TradeOrder";
            this.Text = "TradeOrder";
            this.Load += new System.EventHandler(this.TradeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Routes;
        private System.Windows.Forms.TextBox symbolBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label symbolbs;
        private System.Windows.Forms.Label quantitybs;
        private System.Windows.Forms.Label pricebs;
        private System.Windows.Forms.Label routebs;
        private System.Windows.Forms.Label orderbs;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.ComboBox routeBox;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Label ordertypebs;
        private System.Windows.Forms.Label tifbs;
        private System.Windows.Forms.ComboBox ordertypeBox;
        private System.Windows.Forms.ComboBox tifBox;
        private System.Windows.Forms.Label orderID;
        private System.Windows.Forms.TextBox orderIDbox;
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}