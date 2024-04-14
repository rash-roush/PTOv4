namespace ManagerViewHistory
{
    partial class ManagerPTOHistory
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
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnFilterEmpId = new System.Windows.Forms.Button();
            this.ManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(143, 19);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(149, 21);
            this.cmbDepartment.TabIndex = 0;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // btnFilterEmpId
            // 
            this.btnFilterEmpId.Location = new System.Drawing.Point(151, 74);
            this.btnFilterEmpId.Name = "btnFilterEmpId";
            this.btnFilterEmpId.Size = new System.Drawing.Size(140, 41);
            this.btnFilterEmpId.TabIndex = 1;
            this.btnFilterEmpId.Text = "Filter by Employee ID";
            this.btnFilterEmpId.UseVisualStyleBackColor = true;
            this.btnFilterEmpId.Click += new System.EventHandler(this.btnFilterEmpId_Click);
            // 
            // ManagerDataGridView
            // 
            this.ManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagerDataGridView.Location = new System.Drawing.Point(10, 156);
            this.ManagerDataGridView.Name = "ManagerDataGridView";
            this.ManagerDataGridView.Size = new System.Drawing.Size(778, 283);
            this.ManagerDataGridView.TabIndex = 2;
            this.ManagerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManagerDataGridView_CellContentClick);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(22, 84);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(121, 20);
            this.txtEmployeeID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter by Department";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Call Employee Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerPTOHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.ManagerDataGridView);
            this.Controls.Add(this.btnFilterEmpId);
            this.Controls.Add(this.cmbDepartment);
            this.Name = "ManagerPTOHistory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnFilterEmpId;
        private System.Windows.Forms.DataGridView ManagerDataGridView;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

