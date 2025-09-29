namespace WindowsFormDemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Dọn dẹp tài nguyên
        /// </summary>
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
            this.txtId = new TextBox();
            this.lblId = new Label();
            this.txtName = new TextBox();
            this.lblName = new Label();
            this.txtPrice = new TextBox();
            this.lblPrice = new Label();
            this.txtQuantity = new TextBox();
            this.lblQuantity = new Label();
            this.txtDescription = new TextBox();
            this.lblDescription = new Label();
            this.txtSearch = new TextBox();
            this.lblSearch = new Label();
            this.btnSearch = new Button();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnLoadData = new Button();
            this.grvData = new DataGridView();
            this.lblData = new Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new Point(100, 77);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new Size(100, 23);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new Point(43, 85);
            this.lblId.Name = "lblId";
            this.lblId.Size = new Size(18, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // txtName
            // 
            this.txtName.Location = new Point(100, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(245, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(32, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(39, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new Point(561, 77);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new Size(197, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new Point(504, 85);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new Size(33, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new Point(563, 126);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new Size(197, 23);
            this.txtQuantity.TabIndex = 6;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new Point(504, 134);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new Size(53, 15);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new Point(102, 182);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new Size(658, 23);
            this.txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(29, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(67, 15);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new Point(100, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(561, 23);
            this.txtSearch.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new Point(32, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new Size(58, 15);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Keywords";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new Point(683, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new Point(102, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new Point(301, 405);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(484, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new Point(685, 405);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new Size(75, 23);
            this.btnLoadData.TabIndex = 16;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new EventHandler(this.btnLoadData_Click);
            // 
            // grvData
            // 
            this.grvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData.Location = new Point(102, 235);
            this.grvData.Name = "grvData";
            this.grvData.Size = new Size(658, 150);
            this.grvData.TabIndex = 17;
            this.grvData.CellClick += new DataGridViewCellEventHandler(this.grvData_CellClick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new Point(29, 235);
            this.lblData.Name = "lblData";
            this.lblData.Size = new Size(31, 15);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.grvData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Product Manager";
            this.Load += new EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtDescription;
        private Label lblDescription;
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
