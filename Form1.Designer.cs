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
            lbCash = new Label();
            lb5 = new Label();
            lbChange = new Label();
            lb1000 = new Label();
            lb500 = new Label();
            lb100 = new Label();
            lb50 = new Label();
            lb20 = new Label();
            lb10 = new Label();
            lb1 = new Label();
            tbCash = new TextBox();
            tbChange = new TextBox();
            tb1000 = new TextBox();
            tb100 = new TextBox();
            tb50 = new TextBox();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb500 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            btClear = new Button();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(220, 203);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 0;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(220, 240);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(125, 27);
            tbGreenTeaPrice.TabIndex = 1;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(713, 36);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 2;
            tbTotal.TextChanged += textBox3_TextChanged_1;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(360, 203);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 3;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(360, 243);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(125, 27);
            tbGreenTeaQuantity.TabIndex = 4;
            // 
            // CheckOut
            // 
            CheckOut.Location = new Point(501, 32);
            CheckOut.Name = "CheckOut";
            CheckOut.Size = new Size(94, 480);
            CheckOut.TabIndex = 5;
            CheckOut.Text = "Check Out";
            CheckOut.UseVisualStyleBackColor = true;
            CheckOut.Click += CheckOut_Click;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(633, 43);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 20);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "Total";
            // 
            // cbCoffee
            // 
            cbCoffee.AutoSize = true;
            cbCoffee.Location = new Point(117, 206);
            cbCoffee.Name = "cbCoffee";
            cbCoffee.Size = new Size(75, 24);
            cbCoffee.TabIndex = 7;
            cbCoffee.Text = "Coffee";
            cbCoffee.UseVisualStyleBackColor = true;
            // 
            // cbGreenTea
            // 
            cbGreenTea.AutoSize = true;
            cbGreenTea.Location = new Point(117, 246);
            cbGreenTea.Name = "cbGreenTea";
            cbGreenTea.Size = new Size(97, 24);
            cbGreenTea.TabIndex = 8;
            cbGreenTea.Text = "Green Tea";
            cbGreenTea.UseVisualStyleBackColor = true;
            // 
            // lbCash
            // 
            lbCash.AutoSize = true;
            lbCash.Location = new Point(633, 85);
            lbCash.Name = "lbCash";
            lbCash.Size = new Size(40, 20);
            lbCash.TabIndex = 9;
            lbCash.Text = "Cash";
            lbCash.Click += label1_Click;
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(633, 390);
            lb5.Name = "lb5";
            lb5.Size = new Size(17, 20);
            lb5.TabIndex = 10;
            lb5.Text = "5";
            lb5.Click += label2_Click;
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.Location = new Point(633, 125);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(59, 20);
            lbChange.TabIndex = 11;
            lbChange.Text = "Change";
            // 
            // lb1000
            // 
            lb1000.AutoSize = true;
            lb1000.Location = new Point(633, 162);
            lb1000.Name = "lb1000";
            lb1000.Size = new Size(41, 20);
            lb1000.TabIndex = 12;
            lb1000.Text = "1000";
            // 
            // lb500
            // 
            lb500.AutoSize = true;
            lb500.Location = new Point(633, 203);
            lb500.Name = "lb500";
            lb500.Size = new Size(33, 20);
            lb500.TabIndex = 13;
            lb500.Text = "500";
            // 
            // lb100
            // 
            lb100.AutoSize = true;
            lb100.Location = new Point(633, 243);
            lb100.Name = "lb100";
            lb100.Size = new Size(33, 20);
            lb100.TabIndex = 14;
            lb100.Text = "100";
            lb100.Click += label6_Click;
            // 
            // lb50
            // 
            lb50.AutoSize = true;
            lb50.Location = new Point(633, 279);
            lb50.Name = "lb50";
            lb50.Size = new Size(25, 20);
            lb50.TabIndex = 15;
            lb50.Text = "50";
            // 
            // lb20
            // 
            lb20.AutoSize = true;
            lb20.Location = new Point(633, 316);
            lb20.Name = "lb20";
            lb20.Size = new Size(25, 20);
            lb20.TabIndex = 16;
            lb20.Text = "20";
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new Point(633, 352);
            lb10.Name = "lb10";
            lb10.Size = new Size(25, 20);
            lb10.TabIndex = 17;
            lb10.Text = "10";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(633, 430);
            lb1.Name = "lb1";
            lb1.Size = new Size(17, 20);
            lb1.TabIndex = 18;
            lb1.Text = "1";
            // 
            // tbCash
            // 
            tbCash.Location = new Point(713, 78);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 19;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(713, 118);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 20;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(713, 155);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(125, 27);
            tb1000.TabIndex = 21;
            // 
            // tb100
            // 
            tb100.Location = new Point(713, 236);
            tb100.Name = "tb100";
            tb100.Size = new Size(125, 27);
            tb100.TabIndex = 22;
            // 
            // tb50
            // 
            tb50.Location = new Point(713, 272);
            tb50.Name = "tb50";
            tb50.Size = new Size(125, 27);
            tb50.TabIndex = 23;
            // 
            // tb20
            // 
            tb20.Location = new Point(713, 309);
            tb20.Name = "tb20";
            tb20.Size = new Size(125, 27);
            tb20.TabIndex = 24;
            // 
            // tb10
            // 
            tb10.Location = new Point(713, 345);
            tb10.Name = "tb10";
            tb10.Size = new Size(125, 27);
            tb10.TabIndex = 25;
            // 
            // tb500
            // 
            tb500.Location = new Point(713, 196);
            tb500.Name = "tb500";
            tb500.Size = new Size(125, 27);
            tb500.TabIndex = 26;
            // 
            // tb5
            // 
            tb5.Location = new Point(713, 383);
            tb5.Name = "tb5";
            tb5.Size = new Size(125, 27);
            tb5.TabIndex = 27;
            // 
            // tb1
            // 
            tb1.Location = new Point(713, 423);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 28;
            // 
            // btClear
            // 
            btClear.Location = new Point(713, 469);
            btClear.Name = "btClear";
            btClear.Size = new Size(125, 43);
            btClear.TabIndex = 29;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 618);
            Controls.Add(btClear);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb500);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb1000);
            Controls.Add(tbChange);
            Controls.Add(tbCash);
            Controls.Add(lb1);
            Controls.Add(lb10);
            Controls.Add(lb20);
            Controls.Add(lb50);
            Controls.Add(lb100);
            Controls.Add(lb500);
            Controls.Add(lb1000);
            Controls.Add(lbChange);
            Controls.Add(lb5);
            Controls.Add(lbCash);
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
        private Label lbCash;
        private Label lb5;
        private Label lbChange;
        private Label lb1000;
        private Label lb500;
        private Label lb100;
        private Label lb50;
        private Label lb20;
        private Label lb10;
        private Label lb1;
        private TextBox tbCash;
        private TextBox tbChange;
        private TextBox tb1000;
        private TextBox tb100;
        private TextBox tb50;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb500;
        private TextBox tb5;
        private TextBox tb1;
        private Button btClear;
    }
}
