namespace WinFormsWithDB
{
    partial class Form3
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
            this.refreshBtn = new System.Windows.Forms.Button();
            this.productNumTextBox = new System.Windows.Forms.TextBox();
            this.retrieveAnItemBtn = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitsInStockLabel = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.howManyProductsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(467, 76);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(99, 35);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // productNumTextBox
            // 
            this.productNumTextBox.Location = new System.Drawing.Point(542, 149);
            this.productNumTextBox.Name = "productNumTextBox";
            this.productNumTextBox.Size = new System.Drawing.Size(52, 22);
            this.productNumTextBox.TabIndex = 1;
            // 
            // retrieveAnItemBtn
            // 
            this.retrieveAnItemBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.retrieveAnItemBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveAnItemBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.retrieveAnItemBtn.Location = new System.Drawing.Point(618, 128);
            this.retrieveAnItemBtn.Name = "retrieveAnItemBtn";
            this.retrieveAnItemBtn.Size = new System.Drawing.Size(109, 60);
            this.retrieveAnItemBtn.TabIndex = 2;
            this.retrieveAnItemBtn.Text = "Retrieve a Product";
            this.retrieveAnItemBtn.UseVisualStyleBackColor = false;
            this.retrieveAnItemBtn.Click += new System.EventHandler(this.retrieveAnItemBtn_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.priceLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(272, 231);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 23);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // unitsInStockLabel
            // 
            this.unitsInStockLabel.AutoSize = true;
            this.unitsInStockLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.unitsInStockLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsInStockLabel.Location = new System.Drawing.Point(354, 231);
            this.unitsInStockLabel.Name = "unitsInStockLabel";
            this.unitsInStockLabel.Size = new System.Drawing.Size(103, 23);
            this.unitsInStockLabel.TabIndex = 4;
            this.unitsInStockLabel.Text = "Units In Stock";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(525, 335);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(52, 22);
            this.unitPriceTextBox.TabIndex = 5;
            // 
            // howManyProductsBtn
            // 
            this.howManyProductsBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.howManyProductsBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howManyProductsBtn.Location = new System.Drawing.Point(593, 314);
            this.howManyProductsBtn.Name = "howManyProductsBtn";
            this.howManyProductsBtn.Size = new System.Drawing.Size(134, 60);
            this.howManyProductsBtn.TabIndex = 6;
            this.howManyProductsBtn.Text = "Get Number Of Products";
            this.howManyProductsBtn.UseVisualStyleBackColor = false;
            this.howManyProductsBtn.Click += new System.EventHandler(this.howManyProductsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Click the Refresh button to create the hash table ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Product ID and click on the button to get a product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Units In Stock";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(169, 231);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(47, 23);
            this.productNameLabel.TabIndex = 12;
            this.productNameLabel.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 52);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter a price and click on the button to get the number\r\nof products that cost mo" +
    "re than this price";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.howManyProductsBtn);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.unitsInStockLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.retrieveAnItemBtn);
            this.Controls.Add(this.productNumTextBox);
            this.Controls.Add(this.refreshBtn);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox productNumTextBox;
        private System.Windows.Forms.Button retrieveAnItemBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label unitsInStockLabel;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.Button howManyProductsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label label6;
    }
}