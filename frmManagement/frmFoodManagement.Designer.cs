namespace frmManagement
{
    partial class frmFoodManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtFoodID = new System.Windows.Forms.TextBox();
            txtFoodName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvFood = new System.Windows.Forms.DataGridView();
            cbbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 26);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Food ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 99);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Food Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(298, 26);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(298, 99);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // txtFoodID
            // 
            txtFoodID.Location = new System.Drawing.Point(110, 21);
            txtFoodID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtFoodID.Name = "txtFoodID";
            txtFoodID.Size = new System.Drawing.Size(166, 27);
            txtFoodID.TabIndex = 4;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(110, 94);
            txtFoodName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new System.Drawing.Size(166, 27);
            txtFoodName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(384, 21);
            txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(166, 27);
            txtPrice.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(18, 159);
            btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(85, 26);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(190, 159);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(85, 26);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(350, 159);
            btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(85, 26);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(518, 159);
            btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(85, 26);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new System.Drawing.Point(19, 231);
            dgvFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 62;
            dgvFood.RowTemplate.Height = 33;
            dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvFood.Size = new System.Drawing.Size(582, 119);
            dgvFood.TabIndex = 12;
            dgvFood.CellDoubleClick += dgvFood_CellDoubleClick;
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new System.Drawing.Point(384, 93);
            cbbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new System.Drawing.Size(174, 28);
            cbbCategory.TabIndex = 13;
            // 
            // frmFoodManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 360);
            Controls.Add(cbbCategory);
            Controls.Add(dgvFood);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnCreate);
            Controls.Add(txtPrice);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "frmFoodManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmFoodManagement";
            Load += frmFoodManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.ComboBox cbbCategory;
    }
}