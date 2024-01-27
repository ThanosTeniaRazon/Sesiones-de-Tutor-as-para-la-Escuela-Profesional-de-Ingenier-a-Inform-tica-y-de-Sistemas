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

        private void registroDeCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno();
            alumno.Show();
        }

        private void registroDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocente docente = new FrmDocente();
            docente.Show();
        }

        private void registroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocenteAlumnos  asignacion = new DocenteAlumnos();  
            asignacion.Show();
        }

        private void registroDeMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroTutoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTutoria tutoria = new FrmTutoria();
            tutoria.Show();
        }
    }
}
