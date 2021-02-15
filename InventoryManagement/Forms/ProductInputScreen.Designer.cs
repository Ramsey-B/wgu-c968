namespace InventoryManagement.Forms
{
    partial class ProductInputScreen
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
            this.pageTitle = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.inventoryInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.allPartsTable = new System.Windows.Forms.DataGridView();
            this.associatedPartsTable = new System.Windows.Forms.DataGridView();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.partsSearchInput = new System.Windows.Forms.TextBox();
            this.allPartsTableLabel = new System.Windows.Forms.Label();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.associatedPartsTableLabel = new System.Windows.Forms.Label();
            this.deletePartBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.Location = new System.Drawing.Point(36, 37);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(412, 74);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Add Product";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(36, 393);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(32, 25);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 447);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(36, 498);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(100, 25);
            this.inventoryLabel.TabIndex = 3;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(36, 551);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(36, 607);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(53, 25);
            this.maxLabel.TabIndex = 5;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(346, 607);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(47, 25);
            this.minLabel.TabIndex = 6;
            this.minLabel.Text = "Min";
            // 
            // idInput
            // 
            this.idInput.Enabled = false;
            this.idInput.Location = new System.Drawing.Point(217, 387);
            this.idInput.Name = "idInput";
            this.idInput.ReadOnly = true;
            this.idInput.Size = new System.Drawing.Size(245, 31);
            this.idInput.TabIndex = 7;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(217, 441);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(245, 31);
            this.nameInput.TabIndex = 8;
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(217, 495);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(245, 31);
            this.inventoryInput.TabIndex = 9;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(217, 551);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(245, 31);
            this.priceInput.TabIndex = 10;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(155, 607);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(134, 31);
            this.maxInput.TabIndex = 11;
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(443, 607);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(134, 31);
            this.minInput.TabIndex = 12;
            // 
            // allPartsTable
            // 
            this.allPartsTable.AllowUserToAddRows = false;
            this.allPartsTable.AllowUserToDeleteRows = false;
            this.allPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsTable.Location = new System.Drawing.Point(680, 136);
            this.allPartsTable.Name = "allPartsTable";
            this.allPartsTable.ReadOnly = true;
            this.allPartsTable.RowHeadersVisible = false;
            this.allPartsTable.RowHeadersWidth = 82;
            this.allPartsTable.RowTemplate.Height = 33;
            this.allPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsTable.ShowCellErrors = false;
            this.allPartsTable.ShowEditingIcon = false;
            this.allPartsTable.ShowRowErrors = false;
            this.allPartsTable.Size = new System.Drawing.Size(1043, 282);
            this.allPartsTable.TabIndex = 13;
            // 
            // associatedPartsTable
            // 
            this.associatedPartsTable.AllowUserToAddRows = false;
            this.associatedPartsTable.AllowUserToDeleteRows = false;
            this.associatedPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsTable.Location = new System.Drawing.Point(680, 585);
            this.associatedPartsTable.Name = "associatedPartsTable";
            this.associatedPartsTable.ReadOnly = true;
            this.associatedPartsTable.RowHeadersVisible = false;
            this.associatedPartsTable.RowHeadersWidth = 82;
            this.associatedPartsTable.RowTemplate.Height = 33;
            this.associatedPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsTable.ShowCellErrors = false;
            this.associatedPartsTable.ShowEditingIcon = false;
            this.associatedPartsTable.ShowRowErrors = false;
            this.associatedPartsTable.Size = new System.Drawing.Size(1043, 292);
            this.associatedPartsTable.TabIndex = 14;
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.Location = new System.Drawing.Point(1267, 69);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(100, 36);
            this.partsSearchBtn.TabIndex = 15;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            this.partsSearchBtn.Click += new System.EventHandler(this.partsSearchBtn_Click);
            // 
            // partsSearchInput
            // 
            this.partsSearchInput.Location = new System.Drawing.Point(1392, 74);
            this.partsSearchInput.Name = "partsSearchInput";
            this.partsSearchInput.Size = new System.Drawing.Size(331, 31);
            this.partsSearchInput.TabIndex = 16;
            // 
            // allPartsTableLabel
            // 
            this.allPartsTableLabel.AutoSize = true;
            this.allPartsTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPartsTableLabel.Location = new System.Drawing.Point(684, 97);
            this.allPartsTableLabel.Name = "allPartsTableLabel";
            this.allPartsTableLabel.Size = new System.Drawing.Size(422, 50);
            this.allPartsTableLabel.TabIndex = 17;
            this.allPartsTableLabel.Text = "All candidate Parts";
            // 
            // addPartBtn
            // 
            this.addPartBtn.Location = new System.Drawing.Point(1572, 447);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(105, 53);
            this.addPartBtn.TabIndex = 18;
            this.addPartBtn.Text = "Add";
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // associatedPartsTableLabel
            // 
            this.associatedPartsTableLabel.AutoSize = true;
            this.associatedPartsTableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsTableLabel.Location = new System.Drawing.Point(684, 542);
            this.associatedPartsTableLabel.Name = "associatedPartsTableLabel";
            this.associatedPartsTableLabel.Size = new System.Drawing.Size(734, 50);
            this.associatedPartsTableLabel.TabIndex = 19;
            this.associatedPartsTableLabel.Text = "Parts Associated with the Product";
            // 
            // deletePartBtn
            // 
            this.deletePartBtn.Location = new System.Drawing.Point(1572, 914);
            this.deletePartBtn.Name = "deletePartBtn";
            this.deletePartBtn.Size = new System.Drawing.Size(105, 53);
            this.deletePartBtn.TabIndex = 20;
            this.deletePartBtn.Text = "Delete";
            this.deletePartBtn.UseVisualStyleBackColor = true;
            this.deletePartBtn.Click += new System.EventHandler(this.deletePartBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1424, 996);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 53);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1572, 996);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 53);
            this.cancelBtn.TabIndex = 22;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ProductInputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1873, 1167);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.deletePartBtn);
            this.Controls.Add(this.associatedPartsTableLabel);
            this.Controls.Add(this.addPartBtn);
            this.Controls.Add(this.allPartsTableLabel);
            this.Controls.Add(this.partsSearchInput);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.associatedPartsTable);
            this.Controls.Add(this.allPartsTable);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.inventoryInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.pageTitle);
            this.Name = "ProductInputScreen";
            this.Text = "ProductInputScreen";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox inventoryInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.DataGridView allPartsTable;
        private System.Windows.Forms.DataGridView associatedPartsTable;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.TextBox partsSearchInput;
        private System.Windows.Forms.Label allPartsTableLabel;
        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.Label associatedPartsTableLabel;
        private System.Windows.Forms.Button deletePartBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}