namespace SHoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbCoffeePrice = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbTotal = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            CheckOut = new Button();
            lbTotal = new Label();
            cbCoffee = new CheckBox();
            cbGreenTea = new CheckBox();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(211, 32);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 0;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(211, 74);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(125, 27);
            tbGreenTeaPrice.TabIndex = 1;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(360, 163);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 2;
            tbTotal.TextChanged += textBox3_TextChanged_1;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(360, 32);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 3;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(360, 74);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(125, 27);
            tbGreenTeaQuantity.TabIndex = 4;
            // 
            // CheckOut
            // 
            CheckOut.Location = new Point(531, 32);
            CheckOut.Name = "CheckOut";
            CheckOut.Size = new Size(94, 158);
            CheckOut.TabIndex = 5;
            CheckOut.Text = "Check Out";
            CheckOut.UseVisualStyleBackColor = true;
            CheckOut.Click += CheckOut_Click;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(286, 166);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 20);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "Total";
            // 
            // cbCoffee
            // 
            cbCoffee.AutoSize = true;
            cbCoffee.Location = new Point(104, 35);
            cbCoffee.Name = "cbCoffee";
            cbCoffee.Size = new Size(75, 24);
            cbCoffee.TabIndex = 7;
            cbCoffee.Text = "Coffee";
            cbCoffee.UseVisualStyleBackColor = true;
            // 
            // cbGreenTea
            // 
            cbGreenTea.AutoSize = true;
            cbGreenTea.Location = new Point(104, 76);
            cbGreenTea.Name = "cbGreenTea";
            cbGreenTea.Size = new Size(97, 24);
            cbGreenTea.TabIndex = 8;
            cbGreenTea.Text = "Green Tea";
            cbGreenTea.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbGreenTea);
            Controls.Add(cbCoffee);
            Controls.Add(lbTotal);
            Controls.Add(CheckOut);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbTotal);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(tbCoffeePrice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCoffeePrice;
        private TextBox tbGreenTeaPrice;
        private TextBox tbTotal;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaQuantity;
        private Button CheckOut;
        private Label lbTotal;
        private CheckBox cbCoffee;
        private CheckBox cbGreenTea;
    }
}
