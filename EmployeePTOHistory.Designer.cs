namespace ManagerViewHistory
{
    partial class EmployeePTOHistory
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
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDescendingOrder = new System.Windows.Forms.Button();
            this.btnAscendingOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(43, 160);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.Size = new System.Drawing.Size(734, 269);
            this.EmployeeDataGridView.TabIndex = 0;
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellContentClick);
            // 
            // btnDescendingOrder
            // 
            this.btnDescendingOrder.Location = new System.Drawing.Point(53, 35);
            this.btnDescendingOrder.Name = "btnDescendingOrder";
            this.btnDescendingOrder.Size = new System.Drawing.Size(111, 27);
            this.btnDescendingOrder.TabIndex = 6;
            this.btnDescendingOrder.Text = "Ascending Order";
            this.btnDescendingOrder.UseVisualStyleBackColor = true;
            this.btnDescendingOrder.Click += new System.EventHandler(this.btnDescendingOrder_Click);
            // 
            // btnAscendingOrder
            // 
            this.btnAscendingOrder.Location = new System.Drawing.Point(53, 84);
            this.btnAscendingOrder.Name = "btnAscendingOrder";
            this.btnAscendingOrder.Size = new System.Drawing.Size(113, 23);
            this.btnAscendingOrder.TabIndex = 7;
            this.btnAscendingOrder.Text = "Descending Order";
            this.btnAscendingOrder.UseVisualStyleBackColor = true;
            this.btnAscendingOrder.Click += new System.EventHandler(this.btnAscendingOrder_Click);
            // 
            // EmployeePTOHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAscendingOrder);
            this.Controls.Add(this.btnDescendingOrder);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Name = "EmployeePTOHistory";
            this.Text = "EmployeePTOHistory";
            this.Load += new System.EventHandler(this.EmployeePTOHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Button btnDescendingOrder;
        private System.Windows.Forms.Button btnAscendingOrder;
    }
}