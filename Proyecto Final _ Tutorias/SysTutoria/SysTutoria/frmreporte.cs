using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTutoria
{
    public partial class frmreporte : Form
    {
        public frmreporte()
        {
            InitializeComponent();
        }

        private void frmreporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tutoriaDataSet.tutoria' Puede moverla o quitarla según sea necesario.
            this.tutoriaTableAdapter.Fill(this.tutoriaDataSet.tutoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
