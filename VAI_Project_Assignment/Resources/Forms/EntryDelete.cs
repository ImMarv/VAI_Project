using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment.Forms
{
    public partial class EntryDelete : Form
    {
        private DatabaseOperationsMM _dbOps;
        public EntryDelete()
        {
            InitializeComponent();
            _dbOps = new DatabaseOperationsMM();
            LoadData();
        }
        // this method is in charge of loading all data into the datagrid.
        private void LoadData()
        {
            string searchQuery = ""; //modifiable to filter results
            entryDataGrid.DataSource = _dbOps.GetEntryData(searchQuery);
        }

        // this simply disables the button from showing unless a row is selected.
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            entryDeleteButton.Enabled = entryDataGrid.SelectedRows.Count > 0;
        }

        // worked out with the help of chatGPT (I would have absolutely not been able to do this otherwise.
        private void entryDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (entryDataGrid.SelectedRows.Count >0)
                {
                    // Gets the company_ID from the selected row.
                    int companyIDDel = Convert.ToInt32(entryDataGrid.SelectedRows[0].Cells["Company_ID"].Value);

                    // validation process.
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //call the deleteEntry method IF DELETE is selected.
                    if (result == DialogResult.Yes)
                    {
                        _dbOps.DeleteEntry(companyIDDel);

                        RefreshDataGridView();
                    }
                    

                }
                else
                {
                    MessageBox.Show("No rows selected, please select something?");
                }
            }
            catch (Exception deleteError)
            {
                MessageBox.Show("Error: " + deleteError.Message);
            }
        }
        private void RefreshDataGridView()
        {
            // Get the data again and set it as the DataGridView's data source
            entryDataGrid.DataSource = _dbOps.GetEntryData("");
        }
    }

}
