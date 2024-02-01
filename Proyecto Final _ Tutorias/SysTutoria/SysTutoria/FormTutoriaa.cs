using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTutoria
{
    public partial class FormTutoriaa : Form
    {
        public FormTutoriaa()
        {
            InitializeComponent();
        }
        public void datosyconsultar(int i)
        {
            /* try
             {*/

            int id_asignacion;
            string codigo;
            string fecha;
            string tema;
            string hora;
            string asistencia;
            string docente;


            id_asignacion = Convert.ToInt32(txt_id_asignacion.Text);
            codigo = txt_codigo.Text;
            fecha = lbl_fecha.Text;
            hora = lbl_hora.Text;
            tema = txt_tema.Text;
            docente = txt_coddocente.Text;
            if (rb_si.Checked == true)
            {
                this.lb_asistencia.Text = "Asistio";
                asistencia = lb_asistencia.Text;
            }
            else
            {
                this.lb_asistencia.Text = "Falto";
                asistencia = lb_asistencia.Text;
            }
            Ctutoria tutoria = new Ctutoria(id_asignacion, codigo, fecha, hora, tema, asistencia, docente);
            dataGridView1.DataSource = tutoria.consultar(i);
            /* }
             catch (Exception error)
             {
                 MessageBox.Show("Estudiante ya registrado", "Error de duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            */

        }

        private void FormTutoriaa_Load(object sender, EventArgs e)
        {
            if (login_1.tipo == "Admi")
            {
                Cdocente doc = new Cdocente(lbl_docente.Text, null, null, null, null);
                cbdocente.DataSource = doc.buscardocente();
                cbdocente.DisplayMember = "Datos";
                cbdocente.ValueMember = "CodigoDocentes";
                cbCerrar.Visible = false;
            }
            else if (login_1.tipo == "Usuario")
            {
                panel_docente.Visible = true;
                cbdocente.Visible = false;
                //btn_menu.Visible = false;
                Cdocente doc = new Cdocente(lbl_docente.Text, null, null, null, null);
                string dato = doc.ObtenerDatosUsuario();
                lbl_datos_docente.Text = dato;
                Asignacion asignacion = new Asignacion(null, null, null, null, null, null);
                dataGridView2.DataSource = asignacion.consultardocente(lbl_docente.Text);
                Ctutoria tutoria = new Ctutoria(0, null, null, null, null, null, lbl_docente.Text);
                dataGridView1.DataSource = tutoria.consultardocente();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_id_asignacion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            lbl_fecha.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            lbl_hora.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            txt_tema.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            rb_si.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            txt_coddocente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            datosyconsultar(1);
        }

        private void cbdocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_coddocente.Text = cbdocente.SelectedValue.ToString();
            Asignacion asignacion = new Asignacion(null, null, null, null, null, null);
            dataGridView2.DataSource = asignacion.consultardocente(txt_coddocente.Text);
            Ctutoria tutoria = new Ctutoria(0, null, null, null, null, null, txt_coddocente.Text);
            dataGridView1.DataSource = tutoria.consultardocente();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_asignacion.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
            txt_codigo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
            txt_nombres.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
            txt_ap.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
            txt_am.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString();
            txt_correo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();
            txt_coddocente.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].Value.ToString();
            Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            datosyconsultar(3);
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            string buscar;
            buscar = txt_buscar.Text;
            Asignacion asignacion = new Asignacion(null, null, null, null, null, txt_coddocente.Text);
            dataGridView2.DataSource = asignacion.buscar(buscar);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmreporte reporte = new frmreporte();
            reporte.ShowDialog();
        }
    }
}
