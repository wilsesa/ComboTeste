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

namespace CargarGuardar_e_ComboBoxAnidado
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Tutorial;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            cargar_estado();
            //cargar_uf();
        }
        public void cargar_estado()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT idEstado, Nome FROM estado ORDER BY Nome ASC",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["Nome"] = "Selecciona um Estado";
            dt.Rows.InsertAt(fila, 0);

            cbxEstado.ValueMember = "idEstado";
            cbxEstado.DisplayMember = "Nome";
            cbxEstado.DataSource = dt;
        }

        public void cargar_uf(string idEstado)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT idEstado, UF FROM estado WHERE idEstado = @idEstado", con);
            cmd.Parameters.AddWithValue("idEstado", idEstado);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["UF"] = "--Selecciona--";
            dt.Rows.InsertAt(fila, 0);

            cbxUF.ValueMember = "idEstado";
            cbxUF.DisplayMember = "UF";
            cbxUF.DataSource = dt;
        }

        public void cargarMunicipio(string idEstado)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT idMunicipio, Nome FROM municipio WHERE idEstado = @idEstado", con);
            cmd.Parameters.AddWithValue("idEstado",idEstado);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow dr = dt.NewRow();
            dr["Nome"] = "Seleciona un municipio";
            dt.Rows.InsertAt(dr, 0);

            cbxMunicipio.ValueMember = "idMunicipio";
            cbxMunicipio.DisplayMember = "Nome";
            cbxMunicipio.DataSource = dt;
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxEstado.SelectedValue.ToString() != null)
            {
                string idEstado = cbxEstado.SelectedValue.ToString();
                cargarMunicipio(idEstado);
                cargar_uf(idEstado);
            }
        }
    }
}
