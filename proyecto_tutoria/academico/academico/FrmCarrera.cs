using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace academico
{
    public partial class FrmCarrera : Form
    {
        public FrmCarrera()
        {
            InitializeComponent();
        }
        public void consultar(int i)
        {
            int codigo_carrera;
            string nombre_carrera;
            
            
            codigo_carrera = Int32.Parse(txtcodigo.Text);
            nombre_carrera = txtcodigo.Text;
           

            Ccarrera carrera = new Ccarrera (codigo_carrera,nombre_carrera);
            dataGridView1.DataSource = carrera.consultar(i);
        }
        public void datos(int operacion)
        {
            int codigo_carrera;
            string nombre_carrera;
     

            codigo_carrera = Int32.Parse(txtcodigo.Text);
            nombre_carrera = txtnombre.Text;
            

            Ccarrera carrera = new Ccarrera(codigo_carrera, nombre_carrera);
            dataGridView1.DataSource = carrera.consultar(operacion);
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            datos(1);
            consultar(4);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            datos(2);
            consultar(4);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            datos(3);
            consultar(4);
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            datos(4);
            consultar(4);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int cont = dataGridView1.CurrentRow.Index;
            
            txtcodigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            
           

        }

        private void explorar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Form_carrera_reporte fr = new Form_carrera_reporte();
            carrera_reporte rp = new carrera_reporte();
            DataSet ds = new DataSet();//conjunto de datos tipados
            System.Data.DataTable dt = new System.Data.DataTable();//tabla en memoria
            String consulta = "select * from Tcarrera";//variale para cponsultar
            SqlConnection con = new SqlConnection();//objeto conecciom
            con.ConnectionString = "Server=(local);Database=db_academico;User Id=sa;Password=1234;";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            dt.TableName = "Tcarrera";
            ds.Tables.Add(dt);
            rp.SetDataSource(ds);

            fr.asignar_reporte(rp);
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAlumno aluno = new FrmAlumno();
            aluno.Show();
        }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
