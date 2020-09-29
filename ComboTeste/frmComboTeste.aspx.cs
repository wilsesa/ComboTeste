using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ComboTeste
{
    public partial class frmComboTeste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarListBox1();
            CargarListBox2();
            CargarListBox3();
        }

        public void CargarListBox1()
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True");

            //SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "SELECT * FROM estado";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.HasRows)
            {
                ListBox1.DataSource = sdr;
                ListBox1.DataTextField = "Nome";
                ListBox1.DataValueField = "IdEstado";
                ListBox1.DataBind();
            }
            sqlconn.Close();
        }
        public void CargarListBox2()
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True");

            //SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "SELECT * FROM municipio";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.HasRows)
            {
                ListBox2.DataSource = sdr;
                ListBox2.DataTextField = "Nome";
                ListBox2.DataValueField = "IdMunicipio";
                ListBox2.DataBind();
            }
            sqlconn.Close();
        }
        public void CargarListBox3()
        {
            //string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True");

            //SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "SELECT * FROM estado";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            if (sdr.HasRows)
            {
                ListBox3.DataSource = sdr;
                ListBox3.DataTextField = "UF";
                ListBox3.DataValueField = "IdEstado";
                ListBox3.DataBind();
            }
            sqlconn.Close();
        }
    }
} 