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
        // 1 return data  �觤�ҡ�Ѻ
        // 2 no return data
        // return str "100"
        // return int 100

        
        
        private void CheckOut_Click(object sender, EventArgs e)
        {
           // �ѧ��ѹ�ӹǳ�Ҥ� ����Ѻ�����Ъ����� ����֧��ǹŴ
           double getPriceFromSelectedItems()
            {
                // ��ҹ��Ҩҡ TextBox ��� CheckBox
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
                    // ��Ǩ������� checkboxCoffee �����
                    if (cbCoffee.Checked)
                    {
                        // �ŧ��Ҩҡ string ໹ int
                        iCoffeePrice = int.Parse(strCoffeePrice);
                        iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                    }

                    // ��Ǩ�ͺ checkboxGreen Tea
                    if (cbGreenTea.Checked)
                    {
                        iGreenTeaPrice = int.Parse(strGreenTeaPrice);
                        iGreenTeaQuantity = int.Parse(strGreenTeaQuantity); ;
                    }

                }

                catch (Exception ex)
                {
                    // �ŧ��ҼԴ��Ҵ  ��໹0
                    iCoffeePrice = 0;
                    iCoffeeQuantity = 0;
                    iGreenTeaPrice = 0;
                    iGreenTeaQuantity = 0;
                }

                // �ӹǳ�Ҥ�����Ѻ�����Ъ�����
                int iTotalCoffee = iCoffeePrice * iCoffeeQuantity;
                int iTotalGreenTea = iGreenTeaPrice * iGreenTeaQuantity;

                

                 // ����ǹŴ�Ѻ������¡��
                 double dTotalCoffee = getDiscountPrice(iTotalCoffee, "BEV");
                 double dTotalGreenTea = getDiscountPrice(iTotalGreenTea, "BEV");

                 // �׹����Ҥ������ѧ�ҡ�ѡ��ǹŴ
                 return dTotalCoffee + dTotalGreenTea;
                }
            }
            /// <summary>
            /// �ѧ��ѹ�ӹǳ�Ҥ����ѡ��ǹŴ
            /// </summary>
            /// <param name="pTotal">�Ҥ�����ͧ�Թ���</param>
            /// <param name="pType">�������ͧ�Թ���: ALL, BEV, FOOD</param>
            /// <returns>�Ҥ���ѧ�ѡ��ǹŴ</returns>
            double getDiscountPrice(int pTotal, string pType = "ALL")
            {
                double dDiscount = 0;

                // ����ǹŴ����������ͧ�Թ���
                if (pType == "BEV" && cbDiscountBev.Checked)
                {
                    dDiscount = int.Parse(tbDiscountBev.Text);
                }

                // �׹����Ҥ���ѧ�ҡ�ѡ��ǹŴ
                return pTotal - (pTotal * dDiscount / 100);
            }

        private void button1_Click(object sender, EventArgs e)
        {
            // �ʴ��Ҥ���ѧ�ѡ��ǹŴ� tbTotal
            tbTotal.Text = getPriceFromSelectedItems().ToString();
        }
        //�ӹǹ�Թ�͹
        iChange = iCash - iTotal;

            //�ʴ��ʹ���  �Թ�͹ � TextBox
            //tbTotal.Text = GetPriceFromSelectedItems().ToString();
            tbTotal.Text = iTotal.ToString();
            tbChange.Text = iChange.ToString();

            // ᨡᨧầ���������­ thankyouGhatgpt
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] denominationTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = iChange / denominations[i]; //�ӹǹ���  ����­
                iChange %= denominations[i];           //�Թ��������
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
