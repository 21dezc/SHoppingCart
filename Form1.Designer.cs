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
            groupBox1 = new GroupBox();
            cbPizza = new CheckBox();
            cbNoodle = new CheckBox();
            tbPizzaQuantity = new TextBox();
            tbNoodleQuantity = new TextBox();
            tbPizzaPrice = new TextBox();
            tbNoodlePrice = new TextBox();
            GFood = new GroupBox();
            cbBeverage = new CheckBox();
            cbAll = new CheckBox();
            tbBeverage = new TextBox();
            tbAll = new TextBox();
            GDiscount = new GroupBox();
            cbFood = new CheckBox();
            tbFood = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            GDiscount.SuspendLayout();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(220, 84);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 0;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(220, 121);
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
            tbCoffeeQuantity.Location = new Point(360, 84);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 3;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(360, 124);
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
            cbCoffee.Location = new Point(117, 87);
            cbCoffee.Name = "cbCoffee";
            cbCoffee.Size = new Size(75, 24);
            cbCoffee.TabIndex = 7;
            cbCoffee.Text = "Coffee";
            cbCoffee.UseVisualStyleBackColor = true;
            // 
            // cbGreenTea
            // 
            cbGreenTea.AutoSize = true;
            cbGreenTea.Location = new Point(117, 127);
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
            // groupBox1
            // 
            groupBox1.Location = new Point(109, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 137);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverage";
            // 
            // cbPizza
            // 
            cbPizza.AutoSize = true;
            cbPizza.Location = new Point(117, 274);
            cbPizza.Name = "cbPizza";
            cbPizza.Size = new Size(65, 24);
            cbPizza.TabIndex = 36;
            cbPizza.Text = "Pizza";
            cbPizza.UseVisualStyleBackColor = true;
            // 
            // cbNoodle
            // 
            cbNoodle.AutoSize = true;
            cbNoodle.Location = new Point(117, 234);
            cbNoodle.Name = "cbNoodle";
            cbNoodle.Size = new Size(81, 24);
            cbNoodle.TabIndex = 35;
            cbNoodle.Text = "Noodle";
            cbNoodle.UseVisualStyleBackColor = true;
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(360, 271);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(125, 27);
            tbPizzaQuantity.TabIndex = 34;
            // 
            // tbNoodleQuantity
            // 
            tbNoodleQuantity.Location = new Point(360, 231);
            tbNoodleQuantity.Name = "tbNoodleQuantity";
            tbNoodleQuantity.Size = new Size(125, 27);
            tbNoodleQuantity.TabIndex = 33;
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(220, 268);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.Size = new Size(125, 27);
            tbPizzaPrice.TabIndex = 32;
            // 
            // tbNoodlePrice
            // 
            tbNoodlePrice.Location = new Point(220, 231);
            tbNoodlePrice.Name = "tbNoodlePrice";
            tbNoodlePrice.Size = new Size(125, 27);
            tbNoodlePrice.TabIndex = 31;
            // 
            // GFood
            // 
            GFood.Location = new Point(109, 190);
            GFood.Name = "GFood";
            GFood.Size = new Size(386, 137);
            GFood.TabIndex = 37;
            GFood.TabStop = false;
            GFood.Text = "Food";
            // 
            // cbBeverage
            // 
            cbBeverage.AutoSize = true;
            cbBeverage.Location = new Point(117, 417);
            cbBeverage.Name = "cbBeverage";
            cbBeverage.Size = new Size(93, 24);
            cbBeverage.TabIndex = 43;
            cbBeverage.Text = "Beverage";
            cbBeverage.UseVisualStyleBackColor = true;
            // 
            // cbAll
            // 
            cbAll.AutoSize = true;
            cbAll.Location = new Point(117, 377);
            cbAll.Name = "cbAll";
            cbAll.Size = new Size(49, 24);
            cbAll.TabIndex = 42;
            cbAll.Text = "All";
            cbAll.UseVisualStyleBackColor = true;
            cbAll.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // tbBeverage
            // 
            tbBeverage.Location = new Point(339, 412);
            tbBeverage.Name = "tbBeverage";
            tbBeverage.Size = new Size(125, 27);
            tbBeverage.TabIndex = 41;
            // 
            // tbAll
            // 
            tbAll.Location = new Point(339, 374);
            tbAll.Name = "tbAll";
            tbAll.Size = new Size(125, 27);
            tbAll.TabIndex = 40;
            // 
            // GDiscount
            // 
            GDiscount.Controls.Add(label3);
            GDiscount.Controls.Add(label2);
            GDiscount.Controls.Add(label1);
            GDiscount.Controls.Add(tbFood);
            GDiscount.Controls.Add(cbFood);
            GDiscount.Location = new Point(109, 333);
            GDiscount.Name = "GDiscount";
            GDiscount.Size = new Size(386, 157);
            GDiscount.TabIndex = 44;
            GDiscount.TabStop = false;
            GDiscount.Text = "Discount";
            // 
            // cbFood
            // 
            cbFood.AutoSize = true;
            cbFood.Location = new Point(8, 123);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(65, 24);
            cbFood.TabIndex = 0;
            cbFood.Text = "Food";
            cbFood.UseVisualStyleBackColor = true;
            cbFood.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // tbFood
            // 
            tbFood.Location = new Point(230, 118);
            tbFood.Name = "tbFood";
            tbFood.Size = new Size(125, 27);
            tbFood.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 48);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 45;
            label1.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 82);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 47;
            label2.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 121);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 48;
            label3.Text = "%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 618);
            Controls.Add(cbBeverage);
            Controls.Add(cbAll);
            Controls.Add(tbBeverage);
            Controls.Add(tbAll);
            Controls.Add(GDiscount);
            Controls.Add(cbPizza);
            Controls.Add(cbNoodle);
            Controls.Add(tbPizzaQuantity);
            Controls.Add(tbNoodleQuantity);
            Controls.Add(tbPizzaPrice);
            Controls.Add(tbNoodlePrice);
            Controls.Add(GFood);
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
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            GDiscount.ResumeLayout(false);
            GDiscount.PerformLayout();
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
        private GroupBox groupBox1;
        private CheckBox cbPizza;
        private CheckBox cbNoodle;
        private TextBox tbPizzaQuantity;
        private TextBox tbNoodleQuantity;
        private TextBox tbPizzaPrice;
        private TextBox tbNoodlePrice;
        private GroupBox GFood;
        private CheckBox cbBeverage;
        private CheckBox cbAll;
        private TextBox tbBeverage;
        private TextBox tbAll;
        private GroupBox GDiscount;
        private CheckBox cbFood;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbFood;
    }
}
