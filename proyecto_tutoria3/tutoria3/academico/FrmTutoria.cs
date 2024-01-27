using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace academico
{
    public partial class FrmTutoria : Form
    {
        public FrmTutoria()
        {
            InitializeComponent();
        }
        DateTime hoy = DateTime.Now;
        public void datosyconsultar(int i)
          {
            try { 
             
              string Codigo;
              string fecha;
              string tema;
              string asistencia;
             

              Codigo = txt_codigo.Text;
              fecha = lbl_fecha.Text;
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
              Ctutoria tutoria = new Ctutoria(Codigo, fecha, tema, asistencia);
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
                string tema;
                string asistencia;


                Codigo = txt_codigo.Text;
                fecha = lbl_fecha.Text;
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
                Ctutoria tutoria = new Ctutoria(Codigo, fecha, tema, asistencia);
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
            Docente = txt_docente.Text;
            Asignacion asignacion = new Asignacion(null, null, null, null,null, Docente);
            dataGridView2.DataSource = asignacion.consultardocente(Docente);

        }

            SqlConnection conexion =new SqlConnection("Server=LAPTOP-1PDV9BUI\\SQLEXPRESS; Initial Catalog=tutoria;Integrated Security = True;");
            private void FrmTutoria_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = hoy.ToShortDateString();
            txt_hora.Text = hoy.ToShortTimeString();
            
            conexion.Open();
            string consulta = "exec cb_docente";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    cbdocente.Items.Add(reader.GetString(0));
                }
                conexion.Close();
                cbdocente.Items.Insert(0, "Seleccionar");
                cbdocente.SelectedIndex = 0;
            }
            catch (Exception error)
            {
                MessageBox.Show("Estudiante ya registrado", "Error de duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            datosyconsultar(4);
            txt_hora.Visible = false;
            txt_fecha.Visible = false;  

        }
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_fecha.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txt_tema.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            rb_si.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            //txt_correo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            Show();
        }

      
        private void label7_Click(object sender, EventArgs e)
        {
    
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            datosyconsultar(1);
            datosyconsultar(4);
           
        }

        private void cbdocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_docente.Text = cbdocente.SelectedItem.ToString();
            datosAsignacion();
        }

 

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString();
            txt_nombres.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
            txt_ap.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
            txt_am.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString();
            txt_correo.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString();
            txt_docente.Text = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();

            Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            datosyconsultar2(3);
            datosyconsultar2(4);
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
    }
}
