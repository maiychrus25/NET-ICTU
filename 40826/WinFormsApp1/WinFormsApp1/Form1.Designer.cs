namespace WindowsFormDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            lblId = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblPosition = new Label();
            txtPosition = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoadData = new Button();
            lblData = new Label();
            grvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grvData).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(120, 60);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(40, 63);
            lblId.Name = "lblId";
            lblId.Size = new Size(68, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Mã NV (ID)";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Tên nhân viên";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 23);
            txtName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(400, 63);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(29, 15);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(460, 60);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 5;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(400, 100);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(50, 15);
            lblPosition.TabIndex = 6;
            lblPosition.Text = "Chức vụ";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(460, 97);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(200, 23);
            txtPosition.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(40, 140);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(44, 15);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 137);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(540, 23);
            txtAddress.TabIndex = 9;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(40, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(75, 15);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Tìm theo tên";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(120, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 23);
            txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(540, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(120, 420);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(260, 420);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(400, 420);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(540, 420);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(120, 23);
            btnLoadData.TabIndex = 16;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(40, 180);
            lblData.Name = "lblData";
            lblData.Size = new Size(78, 15);
            lblData.TabIndex = 17;
            lblData.Text = "Danh sách NV";
            // 
            // grvData
            // 
            grvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvData.Location = new Point(120, 180);
            grvData.Name = "grvData";
            grvData.Size = new Size(540, 220);
            grvData.TabIndex = 18;
            grvData.CellClick += grvData_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 480);
            Controls.Add(grvData);
            Controls.Add(lblData);
            Controls.Add(btnLoadData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPosition);
            Controls.Add(lblPosition);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Quản lý nhân viên";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Label lblName;
        private TextBox txtName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblPosition;
        private TextBox txtPosition;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoadData;
        private Label lblData;
        private DataGridView grvData;
    }
}
