namespace frmManagement
{
    partial class frmReservation
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
            dgvRevervation = new System.Windows.Forms.DataGridView();
            txtReservation = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtOrderId = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtCustomerId = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtAccountId = new System.Windows.Forms.TextBox();
            lbasassa = new System.Windows.Forms.Label();
            txtDepositvalue = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtDeposit = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtNumberguest = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            dtimeRDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvRevervation).BeginInit();
            SuspendLayout();
            // 
            // dgvRevervation
            // 
            dgvRevervation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevervation.Location = new System.Drawing.Point(5, 279);
            dgvRevervation.Name = "dgvRevervation";
            dgvRevervation.RowHeadersWidth = 51;
            dgvRevervation.RowTemplate.Height = 29;
            dgvRevervation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvRevervation.Size = new System.Drawing.Size(1025, 240);
            dgvRevervation.TabIndex = 0;
            dgvRevervation.CellClick += dgvRevervation_CellClick;
            dgvRevervation.CellDoubleClick += dgvRevervation_CellDoubleClick;
            // 
            // txtReservation
            // 
            txtReservation.Enabled = false;
            txtReservation.Location = new System.Drawing.Point(163, 20);
            txtReservation.Name = "txtReservation";
            txtReservation.Size = new System.Drawing.Size(203, 27);
            txtReservation.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "Reservation ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(31, 77);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Order ID";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new System.Drawing.Point(163, 74);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new System.Drawing.Size(203, 27);
            txtOrderId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 20);
            label3.TabIndex = 6;
            label3.Text = "Customer ID";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new System.Drawing.Point(163, 125);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new System.Drawing.Size(203, 27);
            txtCustomerId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(31, 181);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 20);
            label4.TabIndex = 8;
            label4.Text = "Account ID";
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new System.Drawing.Point(163, 178);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new System.Drawing.Size(203, 27);
            txtAccountId.TabIndex = 7;
            // 
            // lbasassa
            // 
            lbasassa.AutoSize = true;
            lbasassa.Location = new System.Drawing.Point(496, 181);
            lbasassa.Name = "lbasassa";
            lbasassa.Size = new System.Drawing.Size(101, 20);
            lbasassa.TabIndex = 16;
            lbasassa.Text = "Deposit Value";
            // 
            // txtDepositvalue
            // 
            txtDepositvalue.Location = new System.Drawing.Point(645, 178);
            txtDepositvalue.Name = "txtDepositvalue";
            txtDepositvalue.Size = new System.Drawing.Size(255, 27);
            txtDepositvalue.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(496, 128);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(96, 20);
            label6.TabIndex = 14;
            label6.Text = "Deposit Type";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new System.Drawing.Point(645, 125);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new System.Drawing.Size(255, 27);
            txtDeposit.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(496, 77);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(104, 20);
            label7.TabIndex = 12;
            label7.Text = "Number Guest";
            // 
            // txtNumberguest
            // 
            txtNumberguest.Location = new System.Drawing.Point(645, 74);
            txtNumberguest.Name = "txtNumberguest";
            txtNumberguest.Size = new System.Drawing.Size(255, 27);
            txtNumberguest.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(496, 23);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(122, 20);
            label8.TabIndex = 10;
            label8.Text = "Reservation Date";
            // 
            // dtimeRDate
            // 
            dtimeRDate.Location = new System.Drawing.Point(645, 20);
            dtimeRDate.Name = "dtimeRDate";
            dtimeRDate.Size = new System.Drawing.Size(255, 27);
            dtimeRDate.TabIndex = 17;
            // 
            // frmReservation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1029, 522);
            Controls.Add(dtimeRDate);
            Controls.Add(lbasassa);
            Controls.Add(txtDepositvalue);
            Controls.Add(label6);
            Controls.Add(txtDeposit);
            Controls.Add(label7);
            Controls.Add(txtNumberguest);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txtAccountId);
            Controls.Add(label3);
            Controls.Add(txtCustomerId);
            Controls.Add(label2);
            Controls.Add(txtOrderId);
            Controls.Add(label1);
            Controls.Add(txtReservation);
            Controls.Add(dgvRevervation);
            Name = "frmReservation";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmReservation";
            ((System.ComponentModel.ISupportInitialize)dgvRevervation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRevervation;
        private System.Windows.Forms.TextBox txtReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label lbasassa;
        private System.Windows.Forms.TextBox txtDepositvalue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumberguest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtimeRDate;
    }
}