using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace academico
{
    public partial class DocenteAlumnos : Form
    {
        public DocenteAlumnos()
        {
            InitializeComponent();
            
        }
        public void consultarAlumno()
        {
            Calumno alumnos = new Calumno(null, null, null, null, null);
            dataGridView1.DataSource = alumnos.consultarAlumno();

        }
        

        public void datosyconsultas(int operacion)
        {
            string cod_asignacion;
            string Codigo;
            string Nombres;
            string AP;
            string AM;
            string Correo;
            string Docente;

            cod_asignacion = txt_asignacion.Text;
            Codigo = txt_codigo.Text;
            Nombres = txt_nombres.Text;
            AP = txt_ap.Text;
            AM = txt_am.Text;
            Correo = txt_correo.Text;   
            Docente = txt_coddocente.Text;

            Asignacion asignacion = new Asignacion(cod_asignacion, Codigo, Nombres, AP, AM, Docente);
            dataGridView2.DataSource = asignacion.consultar(operacion);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_asignacion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_nombres.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txt_ap.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txt_am.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            txt_codigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
  
            Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_asignacion.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
            txt_nombres.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
            txt_ap.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
            txt_am.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
            txt_codigo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString();
            txt_coddocente.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();
            Show();
        }
        SqlConnection conexion = new SqlConnection("Server=LAPTOP-1PDV9BUI\\SQLEXPRESS; Initial Catalog=tutoria;Integrated Security = True;");
        private void DocenteAlumnos_Load(object sender, EventArgs e)
        {

            conexion.Open();
            string consulta = "exec cb_docente";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cb_coddocente.Items.Add(reader.GetString(0));
            }
            conexion.Close();

            txt_asignacion.Visible = false;
            txt_nombres.Visible = false;    
            txt_am.Visible = false;
            txt_codigo.Visible = false;
            txt_ap.Visible = false;
            txt_coddocente.Visible = false;
            txt_codigo.Visible = false;
            txt_correo.Visible = false;
            txt_materno.Visible  = false;
            txt_paterno.Visible = false;   
            txt_nombre.Visible = false;
            consultarAlumno();
            cb_coddocente.Items.Insert(0, "Seleccionar");
            cb_coddocente.SelectedIndex = 0;
        }

        private void btn_mover_Click(object sender, EventArgs e)
        {
            datosyconsultas(1);
            datosyconsultas(4);

        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cb_coddocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_coddocente.Text = cb_coddocente.SelectedItem.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            datosyconsultas(3);
            datosyconsultas(4);
        }
    }
}
