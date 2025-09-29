namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var phone = new Phone
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtPrice.Text),
                    Description = txtDesc.Text,
                };

                context.Phones.Add(phone);
                var result = context.SaveChanges();

                if (result != 0)
                {
                    MessageBox.Show("Them ban ghi thanh cong!");
                    btnLoadData.PerformClick();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var phoneId = int.Parse(txtId.Text);
                var phone = context.Phones.FirstOrDefault(p => p.Id == phoneId);

                if (phone == null)
                {
                    MessageBox.Show("Id san pham khong hop le!");
                }
                else
                {
                    phone.Name = txtName.Text;
                    phone.Price = decimal.Parse(txtPrice.Text);
                    phone.Quantity = int.Parse(txtQuantity.Text);
                    phone.Description = txtDesc.Text;

                    var result = context.SaveChanges();
                    if (result != 0)
                    {
                        MessageBox.Show("Cap nhat ban ghi thanh cong!");
                        btnLoadData.PerformClick();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var phoneId = int.Parse(txtId.Text);
                var phone = context.Phones.FirstOrDefault(p => p.Id == phoneId);

                if (phone == null)
                {
                    MessageBox.Show("Id San pham khong hop le!");
                }
                else
                {
                    context.Phones.Remove(phone);
                    var result = context.SaveChanges();

                    if (result != 0)
                    {
                        MessageBox.Show("Xoa ban ghi thanh cong!");
                        btnLoadData.PerformClick();
                    }
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var phones = context.Phones.ToList();
                grvData.DataSource = phones;
            }
        }

        private void grvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = grvData.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = grvData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = grvData.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = grvData.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDesc.Text = grvData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new PhoneDbContext())
            {
                var keyword = txtSearch.Text;
                var phones = context.Phones.Where(p => p.Name.Contains(keyword)).ToList();
                grvData.DataSource = phones;
            }
        }
    }
}
