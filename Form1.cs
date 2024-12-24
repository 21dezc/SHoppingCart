namespace SHoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            // str
            string strCoffeePrice = tbCoffeePrice.Text;
            string strCoffeeQuantity = tbCoffeeQuantity.Text;

            // ประกาศตัวแปรจำนวน
            int iCoffeePrice = 1;
            int iCoffeeQuantity = 1;
            try
            {
                // num
                iCoffeePrice = int.Parse(strCoffeePrice);
                iCoffeeQuantity = int.Parse(strCoffeeQuantity);
            }
            catch (Exception ex)
            {
                // Message
                MessageBox.Show("กรุณาใส่ตัวเลขที่ถูกต้อง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //คำนวน
            int iTotal = iCoffeePrice * iCoffeeQuantity;


            //num เปน srt
            tbTotal.Text = iTotal.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
