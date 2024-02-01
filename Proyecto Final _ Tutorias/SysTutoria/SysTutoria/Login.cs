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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_contrasena.PasswordChar = '*';
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_usuario.Text) && !String.IsNullOrEmpty(txt_contrasena.Text))
            {

                login_1 lg = new login_1();
                Boolean res = lg.iniciar(txt_usuario.Text, txt_contrasena.Text);

                if (login_1.tipo == "Admi")
                {
                    if (res)
                    {
                        Loading load = new Loading();
                        load.Show();
                        this.Hide();
                        //Principal menu = new Principal();
                        //menu.Show();
                        //this.Hide();
                    }
                }
                if (login_1.tipo == "Usuario")
                {
                    if (res)
                    {
                        FormTutoriaa tutoria = new FormTutoriaa();
                        tutoria.lbl_docente.Text = txt_usuario.Text;
                        tutoria.Show();
                        this.Hide();
                    }
                }
                else
                {
                    //MessageBox.Show("Datos incorrectos");

                }
                txt_usuario.Text = "";
                txt_usuario.Text = "";
                txt_usuario.Focus();

            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
