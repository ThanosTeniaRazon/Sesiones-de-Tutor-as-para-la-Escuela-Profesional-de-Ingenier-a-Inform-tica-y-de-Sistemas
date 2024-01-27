using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FrmCarrera carrera = new FrmCarrera();
            carrera.Show();
        }

        private void registroDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno();
            alumno.Show();
        }

        private void registroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCurso curso = new FrmCurso();
            curso.Show();
        }

        private void registroDeMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricula matricula = new FrmMatricula();
            matricula.Show();
        }
    }
}
