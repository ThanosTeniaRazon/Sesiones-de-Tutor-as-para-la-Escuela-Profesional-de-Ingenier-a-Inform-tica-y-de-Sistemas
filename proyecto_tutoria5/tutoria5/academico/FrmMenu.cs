using System;
using System.Windows.Forms;

namespace academico
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            
        }
        
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            FrmAlumno alumnos = new FrmAlumno();
            alumnos.Show();
            this.Hide();
        }

        private void btn_docentes_Click(object sender, EventArgs e)
        {
            FrmDocente docentes = new FrmDocente();
            docentes.Show();
            this.Hide();
        }

        private void btn_asignacion_Click(object sender, EventArgs e)
        {
            DocenteAlumnos asignacion = new DocenteAlumnos();
            asignacion.Show();
            this.Hide();
        }

        private void btn_tutoria_Click(object sender, EventArgs e)
        {
            FrmTutoria tutoria = new FrmTutoria();
            tutoria.Show();
            this.Hide();
        }
    }
}
