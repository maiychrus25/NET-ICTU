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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var book = new Book
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Description = txtDescription.Text,
                };

                context.Books.Add(book);
                int result = context.SaveChanges();

                if (result != 0)
                {
                    MessageBox.Show("Them moi thanh cong!");
                    btnLoadData.PerformClick();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var bookId = int.Parse(txtId.Text);
                var book = context.Books.FirstOrDefault(b => b.Id == bookId);

                if (book == null)
                {
                    MessageBox.Show("Ban ghi khong hop le");
                }
                else
                {
                    book.Name = txtName.Text;
                    book.Price = decimal.Parse(txtPrice.Text);
                    book.Quantity = int.Parse(txtQuantity.Text);
                    book.Description = txtDescription.Text;

                    int result = context.SaveChanges();
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
            using (var context = new BookDbContext())
            {
                var bookId = int.Parse(txtId.Text);
                var book = context.Books.FirstOrDefault();

                if (book == null)
                {
                    MessageBox.Show("ID sach khong hop le!");
                }
                else
                {
                    context.Books.Remove(book);
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
            using (var context = new BookDbContext())
            {
                var books = context.Books.ToList();
                grvData.DataSource = books;
            }
        }

        private void grvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = grvData.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = grvData.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = grvData.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantity.Text = grvData.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescription.Text = grvData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new BookDbContext())
            {
                var keywords = txtSearch.Text;
                var books = context.Books.Where(b => b.Name.Contains(keywords)).ToList();
                grvData.DataSource = books;
            }
        }
    }
}
