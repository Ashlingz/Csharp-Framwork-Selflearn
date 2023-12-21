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
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }
        private Form THIS;
        public OrderDetail(Form THIS)
        {
            InitializeComponent();
            this.THIS = THIS;
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            txtTotalAmount.Text=Product.TotalAmount.ToString("c2");
        }
        public DataGridViewRowCollection Rows
        {
            get => dataGridView.Rows;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            DialogResult result = payment.ShowDialog();
            if(result == DialogResult.OK)
            {
                DialogResult= DialogResult.OK;
                THIS.Dispose();
                new MyProductOrder().Show();
            }
        }
    }
}
