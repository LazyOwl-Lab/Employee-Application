using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employee_Application
{
    public partial class LeaveForm : Form
    {
        dbHelper dbHelper = new dbHelper(); // db obj
        DataTable dtLeaves = new DataTable();
        int empolyeeId;
        int remAnnual;
        int remCasual;
        int remShortleave;
        string userName;
        public LeaveForm(int empolyeeId, int annual, int casual, int shortleave, string userName)
        {
            InitializeComponent();
            this.empolyeeId = empolyeeId;
            this.remAnnual = annual;
            this.remCasual = casual;
            this.remShortleave = shortleave;
            this.userName = userName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbAnnual_CheckedChanged(object sender, EventArgs e)
        {
            dtpDuration.Enabled = false;
            dtpStart.Enabled = true;
            dtpEnd.Enabled = true;
        }

        private void rbCasual_CheckedChanged(object sender, EventArgs e)
        {
            dtpDuration.Enabled = false;
            dtpStart.Enabled = true;
            dtpEnd.Enabled = true;
        }

        private void rbShort_CheckedChanged(object sender, EventArgs e)
        {
            dtpDuration.Enabled = true;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string startdate = dtpStart.Text;
            string enddate = dtpEnd.Text;
            string duration = dtpDuration.Text;
            string query = "";

            if (rbAnnual.Checked)
            {
                if (remAnnual > 0)
                {
                    string leaveType = "Annual";
                    startdate = dtpStart.Text;
                    enddate = dtpEnd.Text;
                    query = "INSERT INTO Leaves (EmployeeID, LeaveType, StartDate, EndDate) " +
                       "VALUES ('" + empolyeeId + "', '" + leaveType + "', '" + startdate + "', '" + enddate + "')";
                }
                else
                {
                    MessageBox.Show("No Annual Leaves are available");
                    return;
                }
            }
            else if (rbCasual.Checked)
            {
                if (remCasual > 0)
                {
                    startdate = dtpStart.Text;
                    enddate = dtpEnd.Text;
                    string leaveType = "Casual";
                    query = "INSERT INTO Leaves (EmployeeID, LeaveType, StartDate, EndDate) " +
                       "VALUES ('" + empolyeeId + "', '" + leaveType + "', '" + startdate + "', '" + enddate + "')";
                }
                else
                {
                    MessageBox.Show("No Casual Leaves are available");
                    return;
                }
            }
            else if (rbShort.Checked)
            {
                if (remShortleave > 0)
                {
                    duration = dtpDuration.Text;
                    string leaveType = "Short";
                    query = "INSERT INTO Leaves (EmployeeID, LeaveType, LeaveDuration) " +
                      "VALUES ('" + empolyeeId + "', '" + leaveType + "', '" + duration + "')";
                }
                else
                {
                    MessageBox.Show("No Short Leaves are available");
                    return;
                }
            }

            SqlCommand sqlCommand = new SqlCommand(query); // Insert sql qurey
            int row = dbHelper.executeQuery(sqlCommand); // Executing the query

            if (row > 0)
            {
                MessageBox.Show("Leave Requested successfully");
            }
            else
            {
                MessageBox.Show("Leave Request Failed");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(userName);
            dashboard.Show();
        }
    }
}
