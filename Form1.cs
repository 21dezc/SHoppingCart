using System.Security.Policy;

namespace SHoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //function or Method
        // 1 return data  ส่งค่ากลับ
        // 2 no return data
        // return str "100"
        // return int 100

        
        
        private void CheckOut_Click(object sender, EventArgs e)
        {
           // ฟังก์ชันคำนวณราคา สำหรับกาแฟและชาเขียว รวมถึงส่วนลด
           double getPriceFromSelectedItems()
            {
                // อ่านค่าจาก TextBox และ CheckBox
                string strCoffeePrice = tbCoffeePrice.Text;
                string strCoffeeQuantity = tbCoffeeQuantity.Text;
                string strGreenTeaPrice = tbGreenTeaPrice.Text;
                string strGreenTeaQuantity = tbGreenTeaQuantity.Text;
                string strCash = tbCash.Text;

                int iCoffeePrice = 0;
                int iCoffeeQuantity = 0;
                int iGreenTeaPrice = 0;
                int iGreenTeaQuantity = 0;

                try
                {
                    // ตรวจว่าได้ติ้ก checkboxCoffee มัะ้ย
                    if (cbCoffee.Checked)
                    {
                        // แปลงค่าจาก string เปน int
                        iCoffeePrice = int.Parse(strCoffeePrice);
                        iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                    }

                    // ตรวจสอบ checkboxGreen Tea
                    if (cbGreenTea.Checked)
                    {
                        iGreenTeaPrice = int.Parse(strGreenTeaPrice);
                        iGreenTeaQuantity = int.Parse(strGreenTeaQuantity); ;
                    }

                }

                catch (Exception ex)
                {
                    // แปลงค่าผิดพลาด  จะเปน0
                    iCoffeePrice = 0;
                    iCoffeeQuantity = 0;
                    iGreenTeaPrice = 0;
                    iGreenTeaQuantity = 0;
                }

                // คำนวณราคาสำหรับกาแฟและชาเขียว
                int iTotalCoffee = iCoffeePrice * iCoffeeQuantity;
                int iTotalGreenTea = iGreenTeaPrice * iGreenTeaQuantity;

                

                 // ใช้ส่วนลดกับแต่ละรายการ
                 double dTotalCoffee = getDiscountPrice(iTotalCoffee, "BEV");
                 double dTotalGreenTea = getDiscountPrice(iTotalGreenTea, "BEV");

                 // คืนค่าราคารวมหลังจากหักส่วนลด
                 return dTotalCoffee + dTotalGreenTea;
                }
            }
            /// <summary>
            /// ฟังก์ชันคำนวณราคาโดยหักส่วนลด
            /// </summary>
            /// <param name="pTotal">ราคารวมของสินค้า</param>
            /// <param name="pType">ประเภทของสินค้า: ALL, BEV, FOOD</param>
            /// <returns>ราคาหลังหักส่วนลด</returns>
            double getDiscountPrice(int pTotal, string pType = "ALL")
            {
                double dDiscount = 0;

                // ใช้ส่วนลดตามประเภทของสินค้า
                if (pType == "BEV" && cbDiscountBev.Checked)
                {
                    dDiscount = int.Parse(tbDiscountBev.Text);
                }

                // คืนค่าราคาหลังจากหักส่วนลด
                return pTotal - (pTotal * dDiscount / 100);
            }

        private void button1_Click(object sender, EventArgs e)
        {
            // แสดงราคาหลังหักส่วนลดใน tbTotal
            tbTotal.Text = getPriceFromSelectedItems().ToString();
        }
        //คำนวนเงินทอน
        iChange = iCash - iTotal;

            //แสดงยอดรวม  เงินทอน ใน TextBox
            //tbTotal.Text = GetPriceFromSelectedItems().ToString();
            tbTotal.Text = iTotal.ToString();
            tbChange.Text = iChange.ToString();

            // แจกแจงแบงค์และเหรียญ thankyouGhatgpt
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] denominationTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = iChange / denominations[i]; //จำนวนแบ้งใบ  เหรียญ
                iChange %= denominations[i];           //เงินที่เหลือ
                denominationTextBoxes[i].Text = count.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbCoffeePrice.Text = "";
            tbCoffeeQuantity.Text = "";
            tbGreenTeaQuantity.Text = "";
            tbGreenTeaPrice.Text = "";
            tbTotal.Text = "";
            tbCash.Text = "";
            tbChange.Text = "";
            tb1000.Text = "";
            tb500.Text = "";
            tb100.Text = "";
            tb50.Text = "";
            tb20.Text = "";
            tb10.Text = "";
            tb5.Text = "";
            tb1.Text = "";
            
            cbCoffee.Checked = false;
            cbGreenTea.Checked = false;
            cbNoodle.Checked = false;
            cbPizza.Checked = false;
            cbFood.Checked = false;
            cbBeverage.Checked = false;
            cbFood.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
