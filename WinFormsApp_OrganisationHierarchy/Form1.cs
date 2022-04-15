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

namespace WinFormsApp_OrganisationHierarchy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=OrganigationHierarchy;Integrated Security=True");

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            con.Open();


            dataDisplay.Visible = true;
            
            GetData();



            con.Close();

          


        }

        void GetData()
        {
            int empid = Convert.ToInt32(txtEmpID.Text);
            SqlCommand cmd = new SqlCommand("exec Display_Details '" + empid + "' ", con);
          
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataDisplay.DataSource = dt;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataDisplay.Visible = true;
            SqlCommand cmd = new SqlCommand("exec Display_Details_All ", con);

            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataDisplay.DataSource = dt;
        }
    }
}
