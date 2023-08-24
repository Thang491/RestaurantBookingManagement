namespace frmManagement
{
    partial class frmOrder
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
            dgvOrrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrrder
            // 
            dgvOrrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrrder.Location = new System.Drawing.Point(-1, 66);
            dgvOrrder.Name = "dgvOrrder";
            dgvOrrder.RowHeadersWidth = 51;
            dgvOrrder.RowTemplate.Height = 29;
            dgvOrrder.Size = new System.Drawing.Size(668, 208);
            dgvOrrder.TabIndex = 0;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(665, 316);
            Controls.Add(dgvOrrder);
            Name = "frmOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmOrder";
            ((System.ComponentModel.ISupportInitialize)dgvOrrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrrder;
    }
}