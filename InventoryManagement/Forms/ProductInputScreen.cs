using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    public partial class ProductInputScreen : Form
    {
        private readonly Product product;
        private readonly bool isModify;

        public ProductInputScreen(Product inputProduct = null)
        {
            InitializeComponent();

            isModify = inputProduct != null;
            product = isModify ? inputProduct : new Product();
            setAllPartsTableData(Inventory.AllParts);
            setAssociatedPartsTableData(product.AssociatedParts);

            if (isModify)
            {
                idInput.Text = product.ProductID.ToString();
                nameInput.Text = product.Name;
                inventoryInput.Text = product.InStock.ToString();
                priceInput.Text = product.Price.ToString();
                minInput.Text = product.Min.ToString();
                maxLabel.Text = product.Max.ToString();
            }
        }

        private void setAllPartsTableData(IList<Part> parts)
        {
            var allPartsBinding = new BindingSource();
            allPartsBinding.DataSource = parts;
            allPartsTable.DataSource = allPartsBinding;
        }

        private void setAssociatedPartsTableData(IList<Part> parts)
        {
            var associatedParts = new BindingSource();
            associatedParts.DataSource = parts;
            associatedPartsTable.DataSource = associatedParts;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(priceInput.Text, out var price) || price <= 0)
            {
                MessageBox.Show("Invalid Price. Price must be a number greater than 0.");
                return;
            }

            int min = 0;
            if (
                !int.TryParse(maxInput.Text, out var max) ||
                !int.TryParse(minInput.Text, out min) ||
                min > max ||
                min < 0 ||
                max <= 0)
            {
                MessageBox.Show("Invalid Min or Max. Both must be whole numbers greater than 0 and min must be less than max");
                return;
            }

            if (!int.TryParse(inventoryInput.Text, out var inStock) || inStock < 0)
            {
                MessageBox.Show("Invalid inventory. Inventory must be a whole number and must not be less than 0.");
                return;
            }

            if (inStock < min || inStock > max)
            {
                MessageBox.Show($"Invalid inventory. Inventory must a number between min ({min}) and max ({max}).");
                return;
            }

            product.Name = nameInput.Text;
            product.InStock = inStock;
            product.Price = price;
            product.Max = max;
            product.Min = min;

            if (isModify)
            {
                Inventory.UpdateProduct(product.ProductID, product);
            }
            else
            {
                Inventory.AddProduct(product);
            }
            Close();
        }

        private void partsSearchBtn_Click(object sender, EventArgs e)
        {
            var results = Inventory.SearchParts(partsSearchInput.Text);
            setAllPartsTableData(results);
        }

        private void addPartBtn_Click(object sender, EventArgs e)
        {
            var part = associatedPartsTable.CurrentRow.DataBoundItem as Part;
            if (part == null)
            {
                MessageBox.Show("Please select a part to add.");
            }
            product.AddAssociatedPart(part);
        }

        private void deletePartBtn_Click(object sender, EventArgs e)
        {
            var part = allPartsTable.CurrentRow.DataBoundItem as Part;
            if (part == null)
            {
                MessageBox.Show("Please select a part to delete.");
            }
            product.RemoveAssociatedPart(part.PartID);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
