using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTutoria
{
    internal class login_1
    {
        private string cadena = "Server=DESKTOP-V5UUCMT\\SQLSERVVER; Initial Catalog=tutoria;Integrated Security = True;";
        public static string usuario = "";
        public static string tipo = "";

        public Boolean iniciar(string user, string contra)
        {
            usuario = "";
            tipo = "";

            SqlConnection con = new SqlConnection(cadena);
            con.Open();

            SqlParameter parnom = new SqlParameter("@usuario", user);
            SqlParameter parcon = new SqlParameter("@contra", contra);

            //SqlCommand cmd = new SqlCommand("select Nombre,tipo from login where Usuario = @usuario and contra COLLATE Latin1_General_CS_AS = @contra", con);
            SqlCommand cmd = new SqlCommand("select tipo from login where Usuario = @usuario and contra COLLATE Latin1_General_CS_AS = @contra", con);
            cmd.Parameters.Add(parnom);
            cmd.Parameters.Add(parcon);

            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                tipo = lector.GetString(0);
            }
            lector.Close();
            con.Close();

            if (string.IsNullOrEmpty(tipo))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
