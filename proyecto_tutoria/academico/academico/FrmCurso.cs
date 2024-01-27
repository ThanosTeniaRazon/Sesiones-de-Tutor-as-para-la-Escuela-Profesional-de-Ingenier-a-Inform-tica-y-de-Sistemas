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
    public partial class FrmCurso : Form
    {
        public FrmCurso()
        {
            InitializeComponent();
        }
        public void consultar(int i)
        {

            int codigo;
            string descripcion;
            

           codigo = Int32.Parse(txtcodigo.Text);
           descripcion = txtdescripcion.Text;
            

            // Calumno carrera = new Calumno (documento, nombres, apellidos, fecha_nacimiento, sexo, foto);
            //dataGridView1.DataSource = carrera.consultar(i);

            Ccurso cursos = new Ccurso(codigo,descripcion);
            dataGridView1.DataSource = cursos.consultar(i);

        }
        public void datos(int operacion)
        {
            int codigo;
            string descripcion;


            codigo = Int32.Parse(txtcodigo.Text);
            descripcion = txtdescripcion.Text;


            // Calumno carrera = new Calumno (documento, nombres, apellidos, fecha_nacimiento, sexo, foto);
            //dataGridView1.DataSource = carrera.consultar(i);

            Ccurso cursos = new Ccurso(codigo, descripcion);
            dataGridView1.DataSource = cursos.consultar(operacion);


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

        private void explorar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Frm_curso_reporte fr = new Frm_curso_reporte();
            curso_reporte rp = new curso_reporte();
            DataSet ds = new DataSet();//conjunto de datos tipados
            System.Data.DataTable dt = new System.Data.DataTable();//tabla en memoria
            String consulta = "select * from Tcurso";//variale para cponsultar
            SqlConnection con = new SqlConnection();//objeto conecciom
            con.ConnectionString = "Server=(local);Database=db_academico;User Id=sa;Password=1234;";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            dt.TableName = "Tcurso";
            ds.Tables.Add(dt);
            rp.SetDataSource(ds);

            fr.asignar_reporte(rp);
            fr.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtdescripcion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMatricula aluno = new FrmMatricula();
            aluno.Show();
        }
    }
}
