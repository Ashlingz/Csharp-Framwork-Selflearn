using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOrder
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            comboDiscount.SelectedIndex = 0;
            txtTotalAmount.Text=totalAmount.ToString("c2");
        }

        private double totalAmount = Product.TotalAmount;
        private double discout, disPrice, payment, cashReceive, cashReturn;

        private void btnPayment_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;

            



            Product.Rows.Clear();
        }

        private void txtCashReceive_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cashReceive=double.Parse(txtCashReceive.Text);
                cashReturn = cashReceive - payment;
                if(cashReturn >= 0)
                {
                    txtCashReturn.ForeColor=Color.Green;
                    btnPayment.Enabled=true;
                }
                else
                {
                    txtCashReturn.ForeColor = Color.Red;
                    btnPayment.Enabled=false;
                }

                txtCashReturn.Text = cashReturn.ToString("c2");
            }
            catch (Exception)
            {
                txtCashReturn.Text = "";
                btnPayment.Enabled= false;
            }
        }

        private double[] dis = { 0, 5, 10, 15, 20 };

        private void comboDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboDiscount.SelectedIndex;
            discout = dis[index];
            disPrice = totalAmount * discout / 100;
            payment = totalAmount - disPrice;
            txtDisPrice.Text = disPrice.ToString("c2");
            txtPayment.Text = payment.ToString("c2");
        }
    }
}
