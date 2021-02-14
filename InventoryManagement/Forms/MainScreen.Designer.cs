namespace InventoryManagement
{
    partial class MainScreen
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
            this.pageHeader = new System.Windows.Forms.Label();
            this.mainPartsTable = new System.Windows.Forms.DataGridView();
            this.partsTableLabel = new System.Windows.Forms.Label();
            this.mainProductsTable = new System.Windows.Forms.DataGridView();
            this.productTableLabel = new System.Windows.Forms.Label();
            this.mainPartAdd = new System.Windows.Forms.Button();
            this.mainPartModify = new System.Windows.Forms.Button();
            this.mainPartDelete = new System.Windows.Forms.Button();
            this.mainProductAdd = new System.Windows.Forms.Button();
            this.mainProductModify = new System.Windows.Forms.Button();
            this.mainProductDelete = new System.Windows.Forms.Button();
            this.mainExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.AutoSize = true;
            this.pageHeader.Location = new System.Drawing.Point(12, 9);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.Size = new System.Drawing.Size(308, 25);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Text = "Inventory Management System";
            // 
            // mainPartsTable
            // 
            this.mainPartsTable.AllowUserToAddRows = false;
            this.mainPartsTable.AllowUserToDeleteRows = false;
            this.mainPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainPartsTable.Location = new System.Drawing.Point(29, 130);
            this.mainPartsTable.MultiSelect = false;
            this.mainPartsTable.Name = "mainPartsTable";
            this.mainPartsTable.ReadOnly = true;
            this.mainPartsTable.RowHeadersVisible = false;
            this.mainPartsTable.RowHeadersWidth = 82;
            this.mainPartsTable.RowTemplate.Height = 33;
            this.mainPartsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainPartsTable.ShowEditingIcon = false;
            this.mainPartsTable.Size = new System.Drawing.Size(1202, 575);
            this.mainPartsTable.StandardTab = true;
            this.mainPartsTable.TabIndex = 1;
            // 
            // partsTableLabel
            // 
            this.partsTableLabel.AutoSize = true;
            this.partsTableLabel.Location = new System.Drawing.Point(24, 92);
            this.partsTableLabel.Name = "partsTableLabel";
            this.partsTableLabel.Size = new System.Drawing.Size(62, 25);
            this.partsTableLabel.TabIndex = 3;
            this.partsTableLabel.Text = "Parts";
            // 
            // mainProductsTable
            // 
            this.mainProductsTable.AllowUserToAddRows = false;
            this.mainProductsTable.AllowUserToDeleteRows = false;
            this.mainProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainProductsTable.Location = new System.Drawing.Point(1288, 130);
            this.mainProductsTable.MultiSelect = false;
            this.mainProductsTable.Name = "mainProductsTable";
            this.mainProductsTable.ReadOnly = true;
            this.mainProductsTable.RowHeadersVisible = false;
            this.mainProductsTable.RowHeadersWidth = 82;
            this.mainProductsTable.RowTemplate.Height = 33;
            this.mainProductsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainProductsTable.ShowEditingIcon = false;
            this.mainProductsTable.Size = new System.Drawing.Size(1182, 575);
            this.mainProductsTable.TabIndex = 4;
            // 
            // productTableLabel
            // 
            this.productTableLabel.AutoSize = true;
            this.productTableLabel.Location = new System.Drawing.Point(1283, 92);
            this.productTableLabel.Name = "productTableLabel";
            this.productTableLabel.Size = new System.Drawing.Size(97, 25);
            this.productTableLabel.TabIndex = 5;
            this.productTableLabel.Text = "Products";
            // 
            // mainPartAdd
            // 
            this.mainPartAdd.Location = new System.Drawing.Point(891, 738);
            this.mainPartAdd.Name = "mainPartAdd";
            this.mainPartAdd.Size = new System.Drawing.Size(101, 53);
            this.mainPartAdd.TabIndex = 6;
            this.mainPartAdd.Text = "Add";
            this.mainPartAdd.UseVisualStyleBackColor = true;
            this.mainPartAdd.Click += new System.EventHandler(this.mainPartAdd_Click);
            // 
            // mainPartModify
            // 
            this.mainPartModify.Location = new System.Drawing.Point(1011, 738);
            this.mainPartModify.Name = "mainPartModify";
            this.mainPartModify.Size = new System.Drawing.Size(101, 53);
            this.mainPartModify.TabIndex = 7;
            this.mainPartModify.Text = "Modify";
            this.mainPartModify.UseVisualStyleBackColor = true;
            this.mainPartModify.Click += new System.EventHandler(this.mainPartModify_Click);
            // 
            // mainPartDelete
            // 
            this.mainPartDelete.Location = new System.Drawing.Point(1130, 738);
            this.mainPartDelete.Name = "mainPartDelete";
            this.mainPartDelete.Size = new System.Drawing.Size(101, 53);
            this.mainPartDelete.TabIndex = 8;
            this.mainPartDelete.Text = "Delete";
            this.mainPartDelete.UseVisualStyleBackColor = true;
            // 
            // mainProductAdd
            // 
            this.mainProductAdd.Location = new System.Drawing.Point(2120, 739);
            this.mainProductAdd.Name = "mainProductAdd";
            this.mainProductAdd.Size = new System.Drawing.Size(101, 53);
            this.mainProductAdd.TabIndex = 9;
            this.mainProductAdd.Text = "Add";
            this.mainProductAdd.UseVisualStyleBackColor = true;
            // 
            // mainProductModify
            // 
            this.mainProductModify.Location = new System.Drawing.Point(2243, 739);
            this.mainProductModify.Name = "mainProductModify";
            this.mainProductModify.Size = new System.Drawing.Size(103, 52);
            this.mainProductModify.TabIndex = 10;
            this.mainProductModify.Text = "Modify";
            this.mainProductModify.UseVisualStyleBackColor = true;
            // 
            // mainProductDelete
            // 
            this.mainProductDelete.Location = new System.Drawing.Point(2367, 738);
            this.mainProductDelete.Name = "mainProductDelete";
            this.mainProductDelete.Size = new System.Drawing.Size(103, 53);
            this.mainProductDelete.TabIndex = 11;
            this.mainProductDelete.Text = "Delete";
            this.mainProductDelete.UseVisualStyleBackColor = true;
            // 
            // mainExit
            // 
            this.mainExit.Location = new System.Drawing.Point(2367, 879);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(98, 53);
            this.mainExit.TabIndex = 12;
            this.mainExit.Text = "Exit";
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2510, 955);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.mainProductDelete);
            this.Controls.Add(this.mainProductModify);
            this.Controls.Add(this.mainProductAdd);
            this.Controls.Add(this.mainPartDelete);
            this.Controls.Add(this.mainPartModify);
            this.Controls.Add(this.mainPartAdd);
            this.Controls.Add(this.productTableLabel);
            this.Controls.Add(this.mainProductsTable);
            this.Controls.Add(this.partsTableLabel);
            this.Controls.Add(this.mainPartsTable);
            this.Controls.Add(this.pageHeader);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.mainPartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainProductsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageHeader;
        private System.Windows.Forms.DataGridView mainPartsTable;
        private System.Windows.Forms.Label partsTableLabel;
        private System.Windows.Forms.DataGridView mainProductsTable;
        private System.Windows.Forms.Label productTableLabel;
        private System.Windows.Forms.Button mainPartAdd;
        private System.Windows.Forms.Button mainPartModify;
        private System.Windows.Forms.Button mainPartDelete;
        private System.Windows.Forms.Button mainProductAdd;
        private System.Windows.Forms.Button mainProductModify;
        private System.Windows.Forms.Button mainProductDelete;
        private System.Windows.Forms.Button mainExit;
    }
}