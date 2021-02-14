using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            
        }

        private void inhouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            partTypeChanged();
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            partTypeChanged();
        }

        private void partTypeChanged()
        {
            if (inhouseRadio.Checked)
            {
                machineOrCompanyLabel.Text = "Machine ID";
            }
            else
            {
                machineOrCompanyLabel.Text = "Company Name";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            }

            Part newPart;
            if (inhouseRadio.Checked)
            {
                newPart = new Inhouse()
                {
                    Name = nameInput.Text,
                    Price = price,
                    InStock = inStock,
                    Min = min,
                    Max = max,
                    MachineID = int.Parse(machineOrCompanyInput.Text)
                };
            }
            else
            {
                newPart = new Outsourced()
                {
                    Name = nameInput.Text,
                    Price = price,
                    InStock = inStock,
                    Min = min,
                    Max = max,
                    CompanyName = machineOrCompanyInput.Text
                };
            }
            Inventory.AddPart(newPart);
            this.Close();
        }
    }
}
