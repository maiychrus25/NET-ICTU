namespace WindowsFormOrders
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSearch;

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 60);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(150, 23);
            // 
            // lblId
            // 
            this.lblId.Text = "Order ID";
            this.lblId.Location = new System.Drawing.Point(40, 60);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 100);
            this.txtCustomerName.Size = new System.Drawing.Size(250, 23);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.Location = new System.Drawing.Point(20, 100);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(120, 140);
            this.dtpOrderDate.Size = new System.Drawing.Size(250, 23);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Text = "Order Date";
            this.lblOrderDate.Location = new System.Drawing.Point(40, 140);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(500, 60);
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 23);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Text = "Total Amount";
            this.lblTotalAmount.Location = new System.Drawing.Point(400, 60);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(500, 100);
            this.txtStatus.Size = new System.Drawing.Size(200, 23);
            // 
            // lblStatus
            // 
            this.lblStatus.Text = "Status";
            this.lblStatus.Location = new System.Drawing.Point(440, 100);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(120, 20);
            this.txtSearch.Size = new System.Drawing.Size(400, 23);
            // 
            // lblSearch
            // 
            this.lblSearch.Text = "Search by Name";
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            // 
            // btnSearch
            // 
            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(540, 20);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(120, 180);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(220, 180);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(320, 180);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.Location = new System.Drawing.Point(420, 180);
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.Location = new System.Drawing.Point(40, 230);
            this.dgvOrders.Size = new System.Drawing.Size(660, 200);
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSearch);
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
