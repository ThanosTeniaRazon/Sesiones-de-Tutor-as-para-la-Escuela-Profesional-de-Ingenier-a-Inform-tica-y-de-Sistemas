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
    public partial class FrmMatricula : Form
    {
        public FrmMatricula()
        {
            InitializeComponent();
        }
        public void consultar(int i)
        {
            int codigo_matricula;
            int documento;
            int codigo;

            codigo_matricula = Int32.Parse(txtmatricula.Text);
           documento= Int32.Parse(txtalumno.Text);
            codigo = Int32.Parse(txtcurso.Text);

            CMatricula matricula = new CMatricula(codigo_matricula,documento,codigo);
            dataGridView1.DataSource = matricula.consultar(i);
        }
        public void datos (int operacion)
        {
            int codigo_matricula;
            int documento;
            int codigo;

            codigo_matricula = Int32.Parse(txtmatricula.Text);
            documento = Int32.Parse(txtalumno.Text);
            codigo = Int32.Parse(txtcurso.Text);

            CMatricula matricula = new CMatricula(codigo_matricula, documento, codigo);
            dataGridView1.DataSource = matricula.consultar(operacion);
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
            Frm_matricula_reporte fr = new Frm_matricula_reporte();
            matricula_reporte rp = new matricula_reporte();
            DataSet ds = new DataSet();//conjunto de datos tipados
            System.Data.DataTable dt = new System.Data.DataTable();//tabla en memoria
            String consulta = "select * from Tmatricula";//variale para cponsultar
            SqlConnection con = new SqlConnection();//objeto conecciom
            con.ConnectionString = "Server=(local);Database=db_academico;User Id=sa;Password=1234;";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            dt.TableName = "Tmatricula";
            ds.Tables.Add(dt);
            rp.SetDataSource(ds);

            fr.asignar_reporte(rp);
            fr.Show();
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {

        }
    }
}
