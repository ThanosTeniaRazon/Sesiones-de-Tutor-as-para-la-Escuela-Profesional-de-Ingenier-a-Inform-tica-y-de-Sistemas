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
    public partial class FrmAlumno : Form
    {
        String rutafoto;
        public FrmAlumno()
        {
            InitializeComponent();
        }
        public void consultar(int i)
        {
           
            int documento;
            string nombres;
            string apellidos;
            string direccion;
            int cod_carrera;
            Image foto;

            documento = Int32.Parse(txdni.Text);
            nombres = txnombres.Text;
            apellidos = txtapellidos.Text;
            direccion = txtdireccion.Text;
                
            cod_carrera = Int32.Parse(txtcarrera.Text);
            foto = pictureBox1.Image;
            Calumno alumnos = new Calumno(documento, nombres, apellidos, direccion, cod_carrera, foto);
            dataGridView1.DataSource = alumnos.consultar(i);

        }
        public void datos(int operacion)
        {
            int documento;
            string nombres;
            string apellidos;
            string direccion;
            int cod_carrera;
            Image foto;

            documento = Int32.Parse(txdni.Text);
            nombres = txnombres.Text;
            apellidos = txtapellidos.Text;
            direccion = txtdireccion.Text;

            cod_carrera = Int32.Parse(txtcarrera.Text);
            foto = pictureBox1.Image;
            Calumno alumnos = new Calumno(documento, nombres, apellidos, direccion, cod_carrera, foto);
            dataGridView1.DataSource = alumnos.consultar(operacion);


        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            txdni.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txnombres.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txtapellidos.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txtdireccion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            txtcarrera.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();


            DataGridViewRow row2 = dataGridView1.CurrentRow;
            DataGridViewImageCell cell2 = row2.Cells[5] as DataGridViewImageCell;
            byte[] imagen2 = (byte[])cell2.Value;
            pictureBox1.Image = byteArraToImage(imagen2);
            Show();

           
        }
        private Image byteArraToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                this.pictureBox1.Load(fd.FileName);
                rutafoto = fd.FileName;
            }
        }

        private void explorar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Frm_alumno_reporte fr = new Frm_alumno_reporte();
            alumno_reporte rp = new alumno_reporte();
            DataSet ds = new DataSet();//conjunto de datos tipados
            System.Data.DataTable dt = new System.Data.DataTable();//tabla en memoria
            String consulta = "select * from Talumno";//variale para cponsultar
            SqlConnection con = new SqlConnection();//objeto conecciom
            con.ConnectionString = "Server=.;Database=db_academico;User Id=sa;Password=1234;";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            da.Fill(dt);
            dt.TableName = "Talumno";
            ds.Tables.Add(dt);
            rp.SetDataSource(ds);

            fr.asignar_reporte(rp);
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCurso aluno = new FrmCurso();
            aluno.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                this.pictureBox1.Load(fd.FileName);
                rutafoto = fd.FileName;
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
