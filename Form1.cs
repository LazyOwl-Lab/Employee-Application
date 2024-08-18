using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace Employee_Application
{
    public partial class Form1 : Form
    {
        dbHelper dbHelper = new dbHelper();//dbHelper object
        DataTable dtEmployees = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (userName == "")
            {
                MessageBox.Show("UserName Cant be Empty");
            }
            else if (password == "")
            {
                MessageBox.Show("Password Cant be Empty");
            }
            else
            {
                string query = "SELECT * FROM Employees WHERE Username = '" + userName + "' AND PasswordHash =  '" + password + "'"; //sql querry
                dbHelper.readDatathroughAdapter(query, dtEmployees);  //calling the querry to check usern & pass present in db
                if (dtEmployees.Rows.Count == 1)
                {
                    MessageBox.Show("Login Success!");
                    dbHelper.closeConn();//to close the conn with the db
                    this.Hide();
                    Dashboard dashboard = new Dashboard(userName);
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
