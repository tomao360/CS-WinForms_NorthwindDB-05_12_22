namespace WinFormsWithDB
{
    partial class Form1
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
            this.orderNum = new System.Windows.Forms.Button();
            this.customerNumBtn = new System.Windows.Forms.Button();
            this.orderNumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderNum
            // 
            this.orderNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderNum.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNum.Location = new System.Drawing.Point(409, 86);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(128, 58);
            this.orderNum.TabIndex = 0;
            this.orderNum.Text = "Get Number of Orders";
            this.orderNum.UseVisualStyleBackColor = false;
            this.orderNum.Click += new System.EventHandler(this.orderNum_Click);
            // 
            // customerNumBtn
            // 
            this.customerNumBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerNumBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNumBtn.Location = new System.Drawing.Point(409, 239);
            this.customerNumBtn.Name = "customerNumBtn";
            this.customerNumBtn.Size = new System.Drawing.Size(128, 60);
            this.customerNumBtn.TabIndex = 1;
            this.customerNumBtn.Text = "Number of Customers";
            this.customerNumBtn.UseVisualStyleBackColor = false;
            this.customerNumBtn.Click += new System.EventHandler(this.customerNumBtn_Click);
            // 
            // orderNumTextBox
            // 
            this.orderNumTextBox.Location = new System.Drawing.Point(553, 106);
            this.orderNumTextBox.Name = "orderNumTextBox";
            this.orderNumTextBox.Size = new System.Drawing.Size(62, 22);
            this.orderNumTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click on the button to get the number \r\nof orders available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click on the button to get the number \r\nof customers\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderNumTextBox);
            this.Controls.Add(this.customerNumBtn);
            this.Controls.Add(this.orderNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orderNum;
        private System.Windows.Forms.Button customerNumBtn;
        private System.Windows.Forms.TextBox orderNumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}