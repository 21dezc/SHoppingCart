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

            // ��С�ȵ���èӹǹ
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
                MessageBox.Show("��س�������Ţ���١��ͧ!", "��ͼԴ��Ҵ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //�ӹǹ
            int iTotal = iCoffeePrice * iCoffeeQuantity;


            //num ໹ srt
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
