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

          public void datosyconsultar(int i)
          {
              string Codigo;
              string fecha;
              string tema;
              string asistencia;
             

              Codigo = txt_codigo.Text;
              fecha = txt_fecha.Text;
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

            conexion.Open();
            string consulta = "exec cb_docente";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cbdocente.Items.Add(reader.GetString(0));
            }
            conexion.Close();
            cbdocente.Items.Insert(0, "Seleccionar");
            cbdocente.SelectedIndex = 0;
           

        }
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
