using System;

using System.Data;

using System.Windows.Forms;
using System.IO;  // For file operations


namespace ManagerViewHistory
{
    public partial class ManagerPTOHistory : Form
    {
        DataTable dataTable = new DataTable();

        public ManagerPTOHistory()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RetrievePTOHistory(@"C:\Users\lastg\OneDrive\Desktop\Concordia\Winter 2024\BTM495\ManagerViewHistory\PTO_Request_Data.csv");
            cmbDepartment.Items.AddRange(new string[] { "All", "Sales", "Human Resources", "Customer Service", "Finance", "Operations", "Marketing", "Research and Development", "Technology" });
            cmbDepartment.SelectedIndex = 0;  // Select "All" by default to show all records initially
        }

        private void RetrievePTOHistory(string filePath)
        {
            string[] csvLines = File.ReadAllLines(filePath);
            if (csvLines.Length > 0)
            {
                string[] columnNames = csvLines[0].Split(',');
                foreach (string columnName in columnNames)
                {
                    dataTable.Columns.Add(columnName);
                }

                for (int i = 1; i < csvLines.Length; i++)
                {
                    string[] rowData = csvLines[i].Split(',');
                    dataTable.Rows.Add(rowData);
                }
            }

            ManagerDataGridView.DataSource = dataTable;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnFilterEmpId_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string empIdFilter = string.Empty;
            string departmentFilter = string.Empty;
            string combinedFilter = string.Empty;

            string filterValue = txtEmployeeID.Text.Trim();  // Assume txtEmployeeID is your TextBox for Employee ID input
            string selectedDepartment = cmbDepartment.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(filterValue) && int.TryParse(filterValue, out int _))
            {
                empIdFilter = $"[Employee ID] = {filterValue}";
            }

            if (selectedDepartment != "All")
            {
                departmentFilter = $"[Department] = '{selectedDepartment}'";
            }

            if (!string.IsNullOrEmpty(empIdFilter) && !string.IsNullOrEmpty(departmentFilter))
            {
                combinedFilter = $"{empIdFilter} AND {departmentFilter}";
            }
            else if (!string.IsNullOrEmpty(empIdFilter))
            {
                combinedFilter = empIdFilter;
            }
            else if (!string.IsNullOrEmpty(departmentFilter))
            {
                combinedFilter = departmentFilter;
            }

            dataTable.DefaultView.RowFilter = combinedFilter;
        }

        private void ManagerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks if necessary
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the EmployeePTOHistory form
            EmployeePTOHistory employeeHistoryForm = new EmployeePTOHistory();
            // Show the Employee PTO History form
            employeeHistoryForm.Show();
        }
    }
}