using InventoryManagement.Forms;
using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            setPartsTableData(Inventory.AllParts);
            mainPartsTable.Columns["InStock"].HeaderText = "Inventory";
        }

        private void InitProductsTable()
        {
            setProductsTableData(Inventory.Products);
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
            if (part == null)
            {
                MessageBox.Show("Please select a part to Modify.");
            }
            new PartInputScreen(part).ShowDialog();
        }

        private void mainPartDelete_Click(object sender, EventArgs e)
        {
            var part = mainPartsTable.CurrentRow.DataBoundItem as Part;
            if (part == null)
            {
                MessageBox.Show("Please select a part to Delete.");
            }
            Inventory.DeletePart(part);
        }

        private void partsSearchBtn_Click(object sender, EventArgs e)
        {
            var results = Inventory.SearchParts(partsSearchInput.Text);
            setPartsTableData(results);
        }

        private void setPartsTableData(IList<Part> parts)
        {
            var partsBinding = new BindingSource();
            partsBinding.DataSource = parts;
            mainPartsTable.DataSource = partsBinding;
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            var results = Inventory.SearchProducts(productSearchInput.Text);
            setProductsTableData(results);
        }

        private void setProductsTableData(IList<Product> products)
        {
            var productsBindings = new BindingSource();
            productsBindings.DataSource = products;
            mainProductsTable.DataSource = productsBindings;
        }

        private void mainProductDelete_Click(object sender, EventArgs e)
        {
            var product = mainProductsTable.CurrentRow.DataBoundItem as Product;
            if (product == null)
            {
                MessageBox.Show("Please select a product to Delete.");
                return;
            }
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete products that have associated parts.");
                return;
            }

            ConfirmDelete(product.Name, product, Inventory.DeleteProduct);
            //Inventory.DeleteProduct(product);
        }

        private void ConfirmDelete<ItemType>(string name, ItemType item, Func<ItemType, bool> callback)
        {
            var dialogResult = MessageBox.Show($"Are you sure you want to permanently delete {name}?", "Please Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            var deleteResult = callback(item);
            if (!deleteResult)
            {
                MessageBox.Show($"Failed to delete {name}.");
            }
        }

        private void mainProductAdd_Click(object sender, EventArgs e)
        {
            new ProductInputScreen().ShowDialog();
        }

        private void mainProductModify_Click(object sender, EventArgs e)
        {
            var product = mainProductsTable.CurrentRow.DataBoundItem as Product;
            if (product == null)
            {
                MessageBox.Show("Please select a product to Modify.");
            }
            new ProductInputScreen(product).ShowDialog();
        }
    }
}
