using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLoadData.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var p = new Product
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Description = txtDescription.Text
                };

                context.Products.Add(p);
                int result = context.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show("Thêm mới thành công!");
                    btnLoadData.PerformClick();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var pId = int.Parse(txtId.Text);
                var p = context.Products.FirstOrDefault(x => x.Id == pId);

                if (p == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm!");
                }
                else
                {
                    p.Name = txtName.Text;
                    p.Price = decimal.Parse(txtPrice.Text);
                    p.Quantity = int.Parse(txtQuantity.Text);
                    p.Description = txtDescription.Text;

                    int result = context.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        btnLoadData.PerformClick();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var pId = int.Parse(txtId.Text);
                var p = context.Products.FirstOrDefault(x => x.Id == pId);

                if (p == null)
                {
                    MessageBox.Show("ID sản phẩm không hợp lệ!");
                }
                else
                {
                    context.Products.Remove(p);
                    var result = context.SaveChanges();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        btnLoadData.PerformClick();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var products = context.Products.ToList();
                grvData.DataSource = products;
            }
        }

        private void grvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh lỗi click header
            {
                txtId.Text = grvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = grvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrice.Text = grvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQuantity.Text = grvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescription.Text = grvData.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new ProductDbContext())
            {
                var keyword = txtSearch.Text;
                var products = context.Products
                    .Where(p => p.Name.Contains(keyword))
                    .ToList();

                grvData.DataSource = products;
            }
        }
    }
}
