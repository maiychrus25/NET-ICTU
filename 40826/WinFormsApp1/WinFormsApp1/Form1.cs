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
            using (var context = new EmployeeDbContext())
            {
                var emp = new Employee
                {
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Position = txtPosition.Text,
                    Address = txtAddress.Text
                };

                context.Employees.Add(emp);
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
            using (var context = new EmployeeDbContext())
            {
                var empId = int.Parse(txtId.Text);
                var emp = context.Employees.FirstOrDefault(e => e.Id == empId);

                if (emp == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên!");
                }
                else
                {
                    emp.Name = txtName.Text;
                    emp.Age = int.Parse(txtAge.Text);
                    emp.Position = txtPosition.Text;
                    emp.Address = txtAddress.Text;

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
            using (var context = new EmployeeDbContext())
            {
                var empId = int.Parse(txtId.Text);
                var emp = context.Employees.FirstOrDefault(e => e.Id == empId);

                if (emp == null)
                {
                    MessageBox.Show("ID nhân viên không hợp lệ!");
                }
                else
                {
                    context.Employees.Remove(emp);
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
            using (var context = new EmployeeDbContext())
            {
                var employees = context.Employees.ToList();
                grvData.DataSource = employees;
            }
        }

        private void grvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh lỗi click header
            {
                txtId.Text = grvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = grvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAge.Text = grvData.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPosition.Text = grvData.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAddress.Text = grvData.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeDbContext())
            {
                var keyword = txtSearch.Text;
                var employees = context.Employees
                    .Where(e => e.Name.Contains(keyword))
                    .ToList();

                grvData.DataSource = employees;
            }
        }
    }
}
