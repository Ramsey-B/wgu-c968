namespace InventoryManagement.Forms
{
    partial class PartInputScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.inventoryInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.machineOrCompanyInput = new System.Windows.Forms.TextBox();
            this.machineOrCompanyLabel = new System.Windows.Forms.Label();
            this.inhouseRadio = new System.Windows.Forms.RadioButton();
            this.outsourcedRadio = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Location = new System.Drawing.Point(12, 9);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(95, 25);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Add Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price / Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Min";
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(317, 84);
            this.idInput.Name = "idInput";
            this.idInput.ReadOnly = true;
            this.idInput.Size = new System.Drawing.Size(218, 31);
            this.idInput.TabIndex = 9;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(317, 146);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(218, 31);
            this.nameInput.TabIndex = 10;
            // 
            // inventoryInput
            // 
            this.inventoryInput.Location = new System.Drawing.Point(317, 212);
            this.inventoryInput.Name = "inventoryInput";
            this.inventoryInput.Size = new System.Drawing.Size(218, 31);
            this.inventoryInput.TabIndex = 11;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(317, 271);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(218, 31);
            this.priceInput.TabIndex = 12;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(317, 330);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(120, 31);
            this.maxInput.TabIndex = 13;
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(567, 330);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(118, 31);
            this.minInput.TabIndex = 14;
            // 
            // machineOrCompanyInput
            // 
            this.machineOrCompanyInput.Location = new System.Drawing.Point(317, 396);
            this.machineOrCompanyInput.Name = "machineOrCompanyInput";
            this.machineOrCompanyInput.Size = new System.Drawing.Size(218, 31);
            this.machineOrCompanyInput.TabIndex = 15;
            // 
            // machineOrCompanyLabel
            // 
            this.machineOrCompanyLabel.AutoSize = true;
            this.machineOrCompanyLabel.Location = new System.Drawing.Point(144, 399);
            this.machineOrCompanyLabel.Name = "machineOrCompanyLabel";
            this.machineOrCompanyLabel.Size = new System.Drawing.Size(120, 25);
            this.machineOrCompanyLabel.TabIndex = 16;
            this.machineOrCompanyLabel.Text = "Machine ID";
            // 
            // inhouseRadio
            // 
            this.inhouseRadio.AutoSize = true;
            this.inhouseRadio.Checked = true;
            this.inhouseRadio.Location = new System.Drawing.Point(237, 12);
            this.inhouseRadio.Name = "inhouseRadio";
            this.inhouseRadio.Size = new System.Drawing.Size(129, 29);
            this.inhouseRadio.TabIndex = 1;
            this.inhouseRadio.TabStop = true;
            this.inhouseRadio.Text = "In-House";
            this.inhouseRadio.UseVisualStyleBackColor = true;
            this.inhouseRadio.CheckedChanged += new System.EventHandler(this.inhouseRadio_CheckedChanged);
            // 
            // outsourcedRadio
            // 
            this.outsourcedRadio.AutoSize = true;
            this.outsourcedRadio.Location = new System.Drawing.Point(484, 12);
            this.outsourcedRadio.Name = "outsourcedRadio";
            this.outsourcedRadio.Size = new System.Drawing.Size(154, 29);
            this.outsourcedRadio.TabIndex = 2;
            this.outsourcedRadio.Text = "Outsourced";
            this.outsourcedRadio.UseVisualStyleBackColor = true;
            this.outsourcedRadio.CheckedChanged += new System.EventHandler(this.outsourcedRadio_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(421, 459);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 50);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(580, 459);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 50);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // PartInputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 547);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.inhouseRadio);
            this.Controls.Add(this.outsourcedRadio);
            this.Controls.Add(this.machineOrCompanyLabel);
            this.Controls.Add(this.machineOrCompanyInput);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.inventoryInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pageTitle);
            this.Name = "PartInputScreen";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox inventoryInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.TextBox machineOrCompanyInput;
        private System.Windows.Forms.Label machineOrCompanyLabel;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.RadioButton inhouseRadio;
        private System.Windows.Forms.RadioButton outsourcedRadio;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}