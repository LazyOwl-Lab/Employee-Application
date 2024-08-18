using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Application
{
    public partial class Dashboard : Form
    {
        dbHelper dbHelper = new dbHelper();
        static DataTable dtEmployees = new DataTable();
        int empolyeeId;
        int annualLeaveBalance;
        int casualLeaveBalance;
        int shortLeaveBalance;

        public Dashboard(string username)
        {
            InitializeComponent();
            lblUsername.Text = username;
            string query = "SELECT * FROM Employees WHERE Username = '" + username + "'"; // select sql query
            dbHelper.readDatathroughAdapter(query, dtEmployees);  // executing the query using the dbHelper obj and store the result in dtEmployees
            dbHelper.closeConn(); // close the db connection
            lblAnnual.Text = dtEmployees.Rows[0]["AnnualLeaveBalance"].ToString();
            lblCasual.Text = dtEmployees.Rows[0]["CasualLeaveBalance"].ToString();
            lblShort.Text = dtEmployees.Rows[0]["ShortLeaveBalance"].ToString();
            annualLeaveBalance = Int32.Parse(lblAnnual.Text);
            casualLeaveBalance = Int32.Parse(lblCasual.Text);
            shortLeaveBalance = Int32.Parse(lblShort.Text);
            empolyeeId = Int32.Parse(dtEmployees.Rows[0]["EmployeeID"].ToString());
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaveForm leaveForm = new LeaveForm(empolyeeId, annualLeaveBalance, casualLeaveBalance, shortLeaveBalance, lblUsername.Text);
            leaveForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageLeaves manageLeaves =  new ManageLeaves(empolyeeId,lblUsername.Text);
            manageLeaves.Show();
        }
    }
}
