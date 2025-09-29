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
            // Load data khi form load
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using var ctx = new SupplierDbContext();
                var list = ctx.Suppliers.OrderBy(s => s.Id).ToList();
                grvData.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInput();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using var ctx = new SupplierDbContext();

                var supplier = new Supplier
                {
                    Name = txtName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                ctx.Suppliers.Add(supplier);
                int result = ctx.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                    LoadData();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn bản ghi hợp lệ để cập nhật.");
                return;
            }

            try
            {
                using var ctx = new SupplierDbContext();
                var s = ctx.Suppliers.FirstOrDefault(x => x.Id == id);
                if (s == null)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp.");
                    return;
                }

                s.Name = txtName.Text.Trim();
                s.Phone = txtPhone.Text.Trim();
                s.Address = txtAddress.Text.Trim();
                s.Email = txtEmail.Text.Trim();

                int result = ctx.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Vui lòng chọn bản ghi hợp lệ để xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var ctx = new SupplierDbContext();
                var s = ctx.Suppliers.FirstOrDefault(x => x.Id == id);
                if (s == null)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp.");
                    return;
                }

                ctx.Suppliers.Remove(s);
                int result = ctx.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var keyword = txtSearch.Text.Trim();
                using var ctx = new SupplierDbContext();
                var list = ctx.Suppliers
                              .Where(s => s.Name.Contains(keyword))
                              .OrderBy(s => s.Id)
                              .ToList();
                grvData.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void grvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // bảo vệ khi click header hoặc ngoài vùng dữ liệu
            if (e.RowIndex < 0 || e.RowIndex >= grvData.Rows.Count) return;

            var row = grvData.Rows[e.RowIndex];
            // giả định DataSource có cột Id, Name, Phone, Address, Email (theo thứ tự)
            txtId.Text = row.Cells["Id"].Value?.ToString() ?? "";
            txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
        }
    }
}
