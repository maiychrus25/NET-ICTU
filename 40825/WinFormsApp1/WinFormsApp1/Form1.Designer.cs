namespace WinFormsApp1
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
            lblId = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            txtDesc = new TextBox();
            lblDesc = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoadData = new Button();
            grvData = new DataGridView();
            lblData = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)grvData).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(36, 87);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(89, 79);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(202, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(89, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 133);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(562, 79);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 23);
            txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(512, 87);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(562, 125);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(202, 23);
            txtQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(503, 133);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(91, 186);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(673, 23);
            txtDesc.TabIndex = 9;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(18, 194);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 8;
            lblDesc.Text = "Description";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(571, 23);
            txtSearch.TabIndex = 11;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(16, 34);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(67, 15);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Description";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(91, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(298, 406);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(512, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(689, 406);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(75, 23);
            btnLoadData.TabIndex = 15;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // grvData
            // 
            grvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvData.Location = new Point(91, 237);
            grvData.Name = "grvData";
            grvData.Size = new Size(673, 150);
            grvData.TabIndex = 16;
            grvData.CellClick += grvData_CellClick;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(18, 237);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 17;
            lblData.Text = "Data";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(689, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(lblData);
            Controls.Add(grvData);
            Controls.Add(btnLoadData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(txtDesc);
            Controls.Add(lblDesc);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private TextBox txtDesc;
        private Label lblDesc;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoadData;
        private DataGridView grvData;
        private Label lblData;
        private Button btnSearch;
    }
}
