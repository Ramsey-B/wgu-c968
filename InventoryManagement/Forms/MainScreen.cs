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

            Inventory.InitParts();
            Inventory.InitProducts();
            LoadTables();
        }
        
        public void LoadTables()
        {
            InitPartsTable();
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
            new PartInputScreen().ShowDialog();
        }

        private void mainPartModify_Click(object sender, EventArgs e)
        {
            var part = mainPartsTable.CurrentRow.DataBoundItem as Part;
            new PartInputScreen(part).ShowDialog();
        }
    }
}
