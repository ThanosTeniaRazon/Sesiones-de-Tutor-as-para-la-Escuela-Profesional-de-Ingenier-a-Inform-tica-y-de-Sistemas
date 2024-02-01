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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            //container(new DashBoard());
        }
        private void container(object _form)
        {
            if (Panel_container_principal.Controls.Count > 0) Panel_container_principal.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            Panel_container_principal.Controls.Add(fm);
            Panel_container_principal.Tag = fm;
            fm.Show();
        }
        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            container(new FrmAlumnos());
        }

        private void btn_docentes_Click(object sender, EventArgs e)
        {
            container(new FrmDocente());
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            container(new DashBoard());
        }

        private void btn_asignacion_Click(object sender, EventArgs e)
        {
            container(new DocenteAlumnos());
        }

        private void btn_tutoria_Click(object sender, EventArgs e)
        {
            //container(new FrmTutoria());
            container(new FormTutoriaa());
        }
    }
}
