using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormOrders
{
    public partial class Form1 : Form
    {
        private OrderDbContext db;

        public Form1()
        {
            InitializeComponent();
            db = new OrderDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvOrders.DataSource = db.Orders.ToList();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvOrders.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                dtpOrderDate.Value = Convert.ToDateTime(row.Cells["OrderDate"].Value);
                txtTotalAmount.Text = row.Cells["TotalAmount"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                CustomerName = txtCustomerName.Text,
                OrderDate = dtpOrderDate.Value,
                TotalAmount = decimal.Parse(txtTotalAmount.Text),
                Status = txtStatus.Text
            };
            db.Orders.Add(order);
            db.SaveChanges();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var order = db.Orders.Find(id);
            if (order != null)
            {
                order.CustomerName = txtCustomerName.Text;
                order.OrderDate = dtpOrderDate.Value;
                order.TotalAmount = decimal.Parse(txtTotalAmount.Text);
                order.Status = txtStatus.Text;
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var order = db.Orders.Find(id);
            if (order != null)
            {
                db.Orders.Remove(order);
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var result = db.Orders
                          .Where(o => o.CustomerName.Contains(keyword))
                          .ToList();
            dgvOrders.DataSource = result;
        }
    }
}
