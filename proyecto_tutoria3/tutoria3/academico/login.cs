using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace academico
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txt_contrasena.PasswordChar = '*';

        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
           if(!String.IsNullOrEmpty(txt_usuario.Text)&& !String.IsNullOrEmpty(txt_contrasena.Text))
            {

                login_1 lg = new login_1();
                Boolean res = lg.iniciar(txt_usuario.Text,txt_contrasena.Text);

                if (login_1.tipo == "Admi")
                    {
                    if (res)
                    {
                        FrmMenu menu = new FrmMenu();
                        menu.Show();
                        this.Hide();
                    }
                }
                if (login_1.tipo =="Usuario")
                {
                    if (res)
                    {
                        FrmTutoria tutoria = new FrmTutoria();
                        tutoria.Show();
                        this.Hide();
                    }
                }
                else
                {
                   // MessageBox.Show("Datos incorrectos");
                    
                }
                txt_usuario.Text = "";
                txt_contrasena.Text = "";
                txt_usuario.Focus();

            }
            }
        }
    }

