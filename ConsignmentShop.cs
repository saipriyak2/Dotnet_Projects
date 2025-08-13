using ConsignmentShopLibrary;

namespace ConsignmentShop
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> ShoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        public ConsignmentShop()
        {
            InitializeComponent();
            SetUpData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            ItemsListBox.DataSource = itemsBinding;

            ItemsListBox.DisplayMember = "Display";
            ItemsListBox.ValueMember = "Display";

            cartBinding.DataSource = ShoppingCartData;
            ShoppingCartListbox.DataSource = cartBinding;

            ShoppingCartListbox.DisplayMember = "Display";
            ShoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorsBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";

        }

        private void SetUpData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about boy",
                Price = 5.80M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl",
                Price = 3.80M,
                Owner = store.Vendors[0]
            });

            store.Name = "Seconds are better";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            // figure out what is selected in the itemlist
            // copy that item to the shopping cart
            // Do we remove item from the shopping cart - no

            Item selectedItem = (Item)ItemsListBox.SelectedItem;
            ShoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //
            foreach (Item item in ShoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price; 
            }
            ShoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            StoreProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }

        private void ItemsListBoxLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
