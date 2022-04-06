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

namespace MyFinances
{
    public partial class Finances : Form
    {
        public Finances()
        {
            InitializeComponent();
        }

        private int userID;

        public void SetUserDetails(string firstname, string lastname, int ID)
        {
            Text = $"You are viewing the finances for {firstname} {lastname}";
            userID = ID;
        }

        private void Finances_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Transactions WHERE UserID=@userid";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("userid", userID);
            QueryDB(cmd);
        }


        public SqlDataReader QueryDB(SqlCommand cmd)
        {
            // connect to the database
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""W:\008. Computing\Student work\2021-2022\Y12\Mr Dring\MyFinances\MyFinances\Finances.mdf"";Integrated Security=True";

            using (SqlConnection c = new SqlConnection(connection))
            {
                // query the users table
                c.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
        }
    }
}
