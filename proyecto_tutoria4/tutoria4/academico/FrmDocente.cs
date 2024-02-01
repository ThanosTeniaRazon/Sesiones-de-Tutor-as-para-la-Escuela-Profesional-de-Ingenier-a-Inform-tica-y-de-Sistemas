using System;
using System.Windows.Forms;

namespace academico
{
    public partial class FrmDocente : Form
    {
        public FrmDocente()
        {
            InitializeComponent();
        }
        public void consultar(int i)
        {
            string Codigo;
            string Nombres;
            string AP;
            string AM;
            string Correo;

            Codigo = txt_codigo.Text;
            Nombres = txt_nombres.Text;
            AP = txt_ap.Text;
            AM = txt_am.Text;
            Correo = txt_correo.Text;

            Cdocente docentes = new Cdocente(Codigo, Nombres, AP, AM, Correo);
            dataGridView1.DataSource = docentes.consultar(i);

        }
        public void datos(int operacion)
        {
            try { 
            string Codigo;
            string Nombres;
            string AP;
            string AM;
            string Correo;

            Codigo = txt_codigo.Text;
            Nombres = txt_nombres.Text;
            AP = txt_ap.Text;
            AM = txt_am.Text;

            Correo = txt_correo.Text;

            Cdocente docentes = new Cdocente(Codigo, Nombres, AP, AM, Correo);
            dataGridView1.DataSource = docentes.consultar(operacion);
            }
            catch (Exception error)
            {
                MessageBox.Show("Estudiante ya registrado", "Error de duplicidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmDocente_Load(object sender, EventArgs e)
        {
            consultar(4);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txt_nombres.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txt_ap.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txt_am.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            txt_correo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

            Show();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
