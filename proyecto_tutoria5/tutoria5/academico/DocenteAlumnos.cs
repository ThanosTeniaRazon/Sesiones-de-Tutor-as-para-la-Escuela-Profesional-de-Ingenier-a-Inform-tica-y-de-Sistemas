using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
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
        public void consultar(int i)
        {
            string Codigo;
            string Nombres;
            string AP;
            string AM;
            string Correo;
            string Docente;

            Codigo = txt_codigo.Text;
            Nombres = txt_nombres.Text;
            AP = txt_ap.Text;
            AM = txt_am.Text;
            Correo = txt_correo.Text;
            Docente = txt_coddocente.Text;

            Asignacion asignacion = new Asignacion( Codigo, Nombres, AP, AM,Correo, Docente);
            dataGridView2.DataSource = asignacion.consultar(i);

        }

        public void datos(int operacion)
        {
            try
            {
                string Codigo;
                string Nombres;
                string AP;
                string AM;
                string Correo;
                string Docente;

                Codigo = txt_codigo.Text;
                Nombres = txt_nombres.Text;
                AP = txt_ap.Text;
                AM = txt_am.Text;
                Correo = txt_correo.Text;
                Docente = txt_coddocente.Text;

                Asignacion asignacion = new Asignacion( Codigo, Nombres, AP, AM,Correo, Docente);
                dataGridView2.DataSource = asignacion.consultar(operacion);
            }
            catch (Exception error)
            {
                MessageBox.Show("Estudiante ya registrado", "Error de duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_nombres.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txt_ap.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txt_am.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            txt_correo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
  
            Show();
        }

        private void DocenteAlumnos_Load(object sender, EventArgs e)
        {
            Cdocente doc = new Cdocente(null,null,null,null,null);
            cb_coddocente.DataSource = doc.buscardocente();
            cb_coddocente.DisplayMember = "Datos";
            cb_coddocente.ValueMember = "CodigoDocentes";

           /* txt_nombres.Visible = false;    
            txt_am.Visible = false;
            txt_codigo.Visible = false;
            txt_ap.Visible = false;
            txt_coddocente.Visible = false;
            txt_correo.Visible = false;*/
            consultarAlumno();
           
            consultar(4);
        }
        
        private void btn_mover_Click(object sender, EventArgs e)
        {
            datos(1);
            consultar(4);

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
            txt_coddocente.Text = cb_coddocente.SelectedValue.ToString();

        }

        private void btneliminar_Click(object sender, EventArgs e)

        {
            datos(3);
            consultar(4);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_ii_asignacion.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
            txt_codigo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
            txt_nombres.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
            txt_ap.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
            txt_am.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString();
            txt_correo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();

            txt_coddocente.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].Value.ToString();

            Show();
        }
    }
}
