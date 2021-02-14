using InventoryManagement.Forms;
using InventoryManagement.Models;
using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Init();
        }
        
        public void Init()
        {
            Inventory.InitParts();
            InitPartsTable();

            Inventory.InitProducts();
            InitProductsTable();
        }

        private void InitPartsTable()
        {
            var partsBinding = new BindingSource();
            partsBinding.DataSource = Inventory.AllParts;
            mainPartsTable.DataSource = partsBinding;
            mainPartsTable.Columns["InStock"].HeaderText = "Inventory";
        }

        private void InitProductsTable()
        {
            var productsBindings = new BindingSource();
            productsBindings.DataSource = Inventory.Products;
            mainProductsTable.DataSource = productsBindings;
            mainProductsTable.Columns["InStock"].HeaderText = "Inventory";
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainPartAdd_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

        private void mainPartModify_Click(object sender, EventArgs e)
        {
            var test = mainPartsTable.CurrentRow.DataBoundItem;
        }
    }
}
