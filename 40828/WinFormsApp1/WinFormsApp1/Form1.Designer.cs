namespace WindowsFormDemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtId = new TextBox();
            lblId = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            btnLoadData = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            grvData = new DataGridView();
            lblData = new Label();

            ((System.ComponentModel.ISupportInitialize)grvData).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(140, 60);
            txtId.Name = "txtId";
            txtId.ReadOnly = true; // id không thể chỉnh sửa
            txtId.Size = new System.Drawing.Size(120, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(30, 63);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(98, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Mã nhà cung cấp";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(30, 100);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(96, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Tên nhà cung cấp";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(140, 97);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(350, 23);
            txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(30, 140);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(65, 15);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(140, 137);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(200, 23);
            txtPhone.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(30, 180);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(44, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(140, 177);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(450, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(30, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(140, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(350, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(140, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(350, 23);
            txtSearch.TabIndex = 10;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new System.Drawing.Point(30, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(73, 15);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Tìm theo tên";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(510, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(80, 25);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += new EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(140, 260);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(90, 27);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(260, 260);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(90, 27);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(380, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(90, 27);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new System.Drawing.Point(510, 260);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new System.Drawing.Size(120, 27);
            btnLoadData.TabIndex = 16;
            btnLoadData.Text = "Tải danh sách";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += new EventHandler(this.btnLoadData_Click);
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new System.Drawing.Point(30, 310);
            lblData.Name = "lblData";
            lblData.Size = new System.Drawing.Size(113, 15);
            lblData.TabIndex = 17;
            lblData.Text = "Danh sách nhà cung cấp";
            // 
            // grvData
            // 
            grvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvData.Location = new System.Drawing.Point(30, 330);
            grvData.Name = "grvData";
            grvData.Size = new System.Drawing.Size(700, 260);
            grvData.TabIndex = 18;
            grvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvData_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(760, 620);
            this.Controls.Add(lblData);
            this.Controls.Add(grvData);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnLoadData);
            this.Controls.Add(btnSearch);
            this.Controls.Add(txtSearch);
            this.Controls.Add(lblSearch);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtAddress);
            this.Controls.Add(lblAddress);
            this.Controls.Add(txtPhone);
            this.Controls.Add(lblPhone);
            this.Controls.Add(txtName);
            this.Controls.Add(lblName);
            this.Controls.Add(txtId);
            this.Controls.Add(lblId);
            this.Name = "Form1";
            this.Text = "Quản lý Nhà cung cấp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(grvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoadData;
        private DataGridView grvData;
        private Label lblData;
    }
}
