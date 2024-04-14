using System;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace ManagerViewHistory
{
    public partial class EmployeePTOHistory : Form
    {
        DataTable dataTable = new DataTable();


        public EmployeePTOHistory()
        {
            InitializeComponent();
        }

        private void StartDateFilterPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EndDateFilterPicker_ValueChanged(object sender, EventArgs e)
        {

        }


        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeePTOHistory_Load(object sender, EventArgs e)
        {
            RetrievePTOHistory(@"C:\Users\lastg\OneDrive\Desktop\Concordia\Winter 2024\BTM495\ManagerViewHistory\Additional_PTO_Requests_for_Jessica_Lee.csv");
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

            EmployeeDataGridView.DataSource = dataTable;
        }
        private void ApplyDateFilter(string order)
        {
            // Assuming the Date Requested column contains valid DateTime objects.
            DataView view = dataTable.DefaultView;
            view.Sort = $"Start {order}";
            EmployeeDataGridView.DataSource = view;
        }

        private void btnDescendingOrder_Click(object sender, EventArgs e)
        {
            ApplyDateFilter("DESC");
        }

        private void btnAscendingOrder_Click(object sender, EventArgs e)
        {
            ApplyDateFilter("ASC");
        }
    }
}
