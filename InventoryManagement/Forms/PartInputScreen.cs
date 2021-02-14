using InventoryManagement.Models;
using System;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    public partial class PartInputScreen : Form
    {
        private readonly bool isModify;
        private readonly Part inputPart;

        public PartInputScreen(Part part = null)
        {
            inputPart = part;
            isModify = inputPart != null;
            InitializeComponent();

            if (isModify)
            {
                SetModifyPartValues(inputPart);
            }
            else
            {
                SetAddPartValues();
            }
        }

        private void SetAddPartValues()
        {
            Text = "Add Part";
            pageTitle.Text = "Add Part";
            inhouseRadio.Checked = true;
            outsourcedRadio.Checked = false;
            partTypeChanged();
        }

        private void SetModifyPartValues(Part part)
        {
            Text = "Modify Part";
            pageTitle.Text = "Modify Part";

            idInput.Text = part.PartID.ToString();
            nameInput.Text = part.Name.ToString();
            inventoryInput.Text = part.InStock.ToString();
            priceInput.Text = part.Price.ToString();
            maxInput.Text = part.Max.ToString();
            minInput.Text = part.Min.ToString();

            inhouseRadio.Checked = part is Inhouse;
            outsourcedRadio.Checked = part is Outsourced;
            if (inhouseRadio.Checked)
            {
                var inhouse = part as Inhouse;
                machineOrCompanyInput.Text = inhouse.MachineID.ToString();
            }
            else
            {
                var outsourced = part as Outsourced;
                machineOrCompanyInput.Text = outsourced.CompanyName;
            }
            partTypeChanged();
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
                return;
            }

            Part newPart;
            if (inhouseRadio.Checked)
            {
                if (!int.TryParse(machineOrCompanyInput.Text, out var machineId) || machineId <= 0)
                {
                    MessageBox.Show("Invalid machine ID. Machine Id must be a whole number greater than 0.");
                    return;
                }
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
           
            if (isModify)
            {
                Inventory.UpdatePart(inputPart.PartID, newPart);
            }
            else
            {
                Inventory.AddPart(newPart);
            }
            Close();
        }
    }
}
