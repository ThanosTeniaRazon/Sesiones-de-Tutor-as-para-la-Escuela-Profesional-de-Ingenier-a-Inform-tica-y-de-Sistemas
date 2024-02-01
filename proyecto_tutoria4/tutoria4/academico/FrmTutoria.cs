using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace academico
{
    public partial class FrmTutoria : Form
    {
        public FrmTutoria()
        {
            InitializeComponent();
        }
        public void datosyconsultar(int i)
          {
            try { 
             
              string Codigo;
              string fecha;
              string tema;
              string hora;
              string asistencia;
             

              Codigo = txt_codigo.Text;
              fecha = lbl_fecha.Text;
              hora = lbl_hora.Text;
              tema = txt_tema.Text;
            if (rb_si.Checked == true)
            {
                this.lb_asistencia.Text = "Asistio";
                asistencia = lb_asistencia.Text;
            }
            else {
                this.lb_asistencia.Text = "Falto";
                asistencia = lb_asistencia.Text;
            }
              Ctutoria tutoria = new Ctutoria(Codigo, fecha,hora, tema, asistencia);
              dataGridView1.DataSource = tutoria.consultar(i);
            }
            catch (Exception error)
            {
                MessageBox.Show("Estudiante ya registrado", "Error de duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void datosyconsultar2(int i)
        {
            try
            {
                string Codigo;
                string fecha;
                string hora;
                string tema;
                string asistencia;

                Codigo = txt_codigo.Text;
                fecha = lbl_fecha.Text;
                hora = lbl_hora.Text;
                tema = txt_tema.Text;
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
                Ctutoria tutoria = new Ctutoria(Codigo, fecha,hora, tema, asistencia);
                dataGridView2.DataSource = tutoria.consultar(i);
            }
            catch (Exception error)
            {
                MessageBox.Show("Estudiante ya registrado", "Error de duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void datosAsignacion ()
        {
            string Docente;
            Docente = cbdocente.Text;
            Asignacion asignacion = new Asignacion(null, null, null, null,null, Docente);
            dataGridView2.DataSource = asignacion.consultardocente(Docente);

        }

            private void FrmTutoria_Load(object sender, EventArgs e)
        {
            if (login_1.tipo == "Admi")
            {
                Cdocente doc = new Cdocente(lbl_docente.Text, null, null, null, null);
                cbdocente.DataSource = doc.buscardocente();
                cbdocente.DisplayMember = "Datos";
                cbdocente.ValueMember = "CodigoDocentes";
            }

            else if (login_1.tipo == "Usuario")
            {
                panel_docente.Visible=true;
                btn_menu.Visible=false; 
                Cdocente doc = new Cdocente(lbl_docente.Text, null, null, null, null);
                string dato = doc.ObtenerDatosUsuario();
                lbl_datos_docente.Text = dato;
                Asignacion asignacion = new Asignacion(null, null, null, null, null, null);
                dataGridView2.DataSource = asignacion.consultardocente(lbl_datos_docente.Text);
            }



        }
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            lbl_fecha.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            lbl_hora.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txt_tema.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            rb_si.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            datosyconsultar(1);
            datosyconsultar(4);
                      
        }

        private void cbdocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_docente.Text = cbdocente.Text.ToString();
            datosAsignacion();
        }

 

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
            txt_nombres.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
            txt_ap.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
            txt_am.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
            txt_correo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString();
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value = cbdocente.ToString();
            Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            datosyconsultar(3);
            datosyconsultar(4);
            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            string buscar;
            buscar = txt_buscar.Text;
            Ctutoria tutoria = new Ctutoria(null, null, null, null,buscar);
            dataGridView1.DataSource = tutoria.buscar(buscar);
        }
    }
}
