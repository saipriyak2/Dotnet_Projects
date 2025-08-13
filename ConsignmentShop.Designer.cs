namespace ConsignmentShop
{
    partial class ConsignmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerText = new Label();
            ItemsListBox = new ListBox();
            ItemsListBoxLabel = new Label();
            addToCart = new Button();
            Shoppingcartlabel = new Label();
            ShoppingCartListbox = new ListBox();
            makePurchase = new Button();
            VendorListBoxLabel = new Label();
            vendorListBox = new ListBox();
            StorePayoutLabel = new Label();
            StoreProfitValue = new Label();
            SuspendLayout();
            // 
            // headerText
            // 
            headerText.AutoSize = true;
            headerText.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerText.Location = new Point(22, 24);
            headerText.Name = "headerText";
            headerText.Size = new Size(790, 86);
            headerText.TabIndex = 0;
            headerText.Text = "ConsignmentShop Demo";
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(43, 155);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(446, 409);
            ItemsListBox.TabIndex = 1;
            // 
            // ItemsListBoxLabel
            // 
            ItemsListBoxLabel.AutoSize = true;
            ItemsListBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemsListBoxLabel.Location = new Point(52, 107);
            ItemsListBoxLabel.Name = "ItemsListBoxLabel";
            ItemsListBoxLabel.Size = new Size(190, 45);
            ItemsListBoxLabel.TabIndex = 2;
            ItemsListBoxLabel.Text = "Store Items";
            ItemsListBoxLabel.Click += ItemsListBoxLabel_Click;
            // 
            // addToCart
            // 
            addToCart.Location = new Point(509, 214);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(237, 53);
            addToCart.TabIndex = 3;
            addToCart.Text = "addToCart ->";
            addToCart.UseVisualStyleBackColor = true;
            addToCart.Click += addToCart_Click;
            // 
            // Shoppingcartlabel
            // 
            Shoppingcartlabel.AutoSize = true;
            Shoppingcartlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Shoppingcartlabel.Location = new Point(835, 107);
            Shoppingcartlabel.Name = "Shoppingcartlabel";
            Shoppingcartlabel.Size = new Size(228, 45);
            Shoppingcartlabel.TabIndex = 5;
            Shoppingcartlabel.Text = "ShoppingCart";
            // 
            // ShoppingCartListbox
            // 
            ShoppingCartListbox.FormattingEnabled = true;
            ShoppingCartListbox.Location = new Point(825, 155);
            ShoppingCartListbox.Name = "ShoppingCartListbox";
            ShoppingCartListbox.Size = new Size(456, 409);
            ShoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            makePurchase.Location = new Point(863, 573);
            makePurchase.Name = "makePurchase";
            makePurchase.Size = new Size(237, 53);
            makePurchase.TabIndex = 6;
            makePurchase.Text = "Purchase";
            makePurchase.UseVisualStyleBackColor = true;
            makePurchase.Click += makePurchase_Click;
            // 
            // VendorListBoxLabel
            // 
            VendorListBoxLabel.AutoSize = true;
            VendorListBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VendorListBoxLabel.Location = new Point(43, 581);
            VendorListBoxLabel.Name = "VendorListBoxLabel";
            VendorListBoxLabel.Size = new Size(142, 45);
            VendorListBoxLabel.TabIndex = 8;
            VendorListBoxLabel.Text = "Vendors";
            // 
            // vendorListBox
            // 
            vendorListBox.FormattingEnabled = true;
            vendorListBox.Location = new Point(34, 629);
            vendorListBox.Name = "vendorListBox";
            vendorListBox.Size = new Size(446, 409);
            vendorListBox.TabIndex = 7;
            // 
            // StorePayoutLabel
            // 
            StorePayoutLabel.AutoSize = true;
            StorePayoutLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StorePayoutLabel.Location = new Point(765, 629);
            StorePayoutLabel.Name = "StorePayoutLabel";
            StorePayoutLabel.Size = new Size(185, 45);
            StorePayoutLabel.TabIndex = 9;
            StorePayoutLabel.Text = "StoreProfit";
            // 
            // StoreProfitValue
            // 
            StoreProfitValue.AutoSize = true;
            StoreProfitValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StoreProfitValue.Location = new Point(974, 629);
            StoreProfitValue.Name = "StoreProfitValue";
            StoreProfitValue.Size = new Size(101, 45);
            StoreProfitValue.TabIndex = 10;
            StoreProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 1057);
            Controls.Add(StoreProfitValue);
            Controls.Add(StorePayoutLabel);
            Controls.Add(VendorListBoxLabel);
            Controls.Add(vendorListBox);
            Controls.Add(makePurchase);
            Controls.Add(Shoppingcartlabel);
            Controls.Add(ShoppingCartListbox);
            Controls.Add(addToCart);
            Controls.Add(ItemsListBoxLabel);
            Controls.Add(ItemsListBox);
            Controls.Add(headerText);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ConsignmentShop";
            Text = "ConsignmentShop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerText;
        private ListBox ItemsListBox;
        private Label ItemsListBoxLabel;
        private Button addToCart;
        private Label Shoppingcartlabel;
        private ListBox ShoppingCartListbox;
        private Button makePurchase;
        private Label VendorListBoxLabel;
        private ListBox vendorListBox;
        private Label StorePayoutLabel;
        private Label StoreProfitValue;
    }
}
