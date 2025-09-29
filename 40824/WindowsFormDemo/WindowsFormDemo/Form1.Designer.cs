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
            txtPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblPrice = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
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
            txtId.Location = new Point(100, 77);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(43, 85);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(32, 134);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 126);
            txtName.Name = "txtName";
            txtName.Size = new Size(245, 23);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(561, 77);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(197, 23);
            txtPrice.TabIndex = 5;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(504, 134);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(563, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(197, 23);
            txtQuantity.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(504, 85);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(102, 182);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(658, 23);
            txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(29, 190);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(100, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(561, 23);
            txtSearch.TabIndex = 11;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(32, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(58, 15);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Keywords";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(683, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(685, 405);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(75, 23);
            btnLoadData.TabIndex = 13;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(484, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(301, 405);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(102, 405);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grvData
            // 
            grvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvData.Location = new Point(102, 235);
            grvData.Name = "grvData";
            grvData.Size = new Size(658, 150);
            grvData.TabIndex = 17;
            grvData.CellClick += grvData_CellClick;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(29, 235);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 18;
            lblData.Text = "Data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblData);
            Controls.Add(grvData);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnLoadData);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtQuantity);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
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
        private Label lblQuantity;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnSearch;
        private Button btnLoadData;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView grvData;
        private Label lblData;
    }
}
