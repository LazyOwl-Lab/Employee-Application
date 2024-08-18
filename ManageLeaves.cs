using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_Application
{
    public partial class ManageLeaves : Form
    {
        dbHelper dbHelper = new dbHelper();
        static DataTable dtLeaves = new DataTable();
        int empolyeeId;
        string userName;
        public ManageLeaves(int empolyeeID,string userName)
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            this.empolyeeId = empolyeeID;
            this.userName = userName;
            string query = "SELECT * FROM Leaves WHERE EmployeeID = '" + empolyeeId + "'"; // read sql query
            dbHelper.readDatathroughAdapter(query, dtLeaves); // executing the query using the dbHelper obj and store the result in dtLeaves
            dbHelper.closeConn(); // close the db connection

            dgvLeaves.DataSource = dtLeaves;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Enabled)
            {
                string query = "DELETE FROM Leaves WHERE LeaveID = " + dgvLeaves.SelectedRows[0].Cells["LeaveID"].Value.ToString();
                SqlCommand sqlCommand = new SqlCommand(query); // update sql query
                int row = dbHelper.executeQuery(sqlCommand); // Executing the query

                if (row > 0)
                    MessageBox.Show("Request Deleted Successfully!");
                else
                    MessageBox.Show("Failed to Delete The Request");

                dtLeaves.Clear();
                query = "SELECT * FROM Leaves WHERE EmployeeID = '" + empolyeeId + "'"; // read sql query
                dbHelper.readDatathroughAdapter(query, dtLeaves); // executing the query using the dbHelper obj and store the result in dtLeaves
                dbHelper.closeConn(); // close the db connection

                dgvLeaves.DataSource = dtLeaves;
            }
        }

        private void dgvLeaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblLeaveID.Text = dgvLeaves.SelectedRows[0].Cells["LeaveID"].Value.ToString();
                if (dgvLeaves.SelectedRows[0].Cells["LeaveStatus"].Value.ToString() == "Pending")
                {
                    btnDelete.Enabled = true;
                }
                else { 
                    btnDelete.Enabled=false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(userName);
            dashboard.Show();
        }
    }
}
