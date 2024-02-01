using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace academico
{
    internal class Asignacion
    {
        private string Codigo;
        private string Nombres;
        private string AP;
        private string AM;
        private string Correo;
        private string Docente;

        private SqlConnection con;

        public Asignacion(string Codigo, string Nombres, string AP, string AM, string Correo, string Docente)
        {

            this.Codigo = Codigo;
            this.Nombres = Nombres;
            this.AP = AP;
            this.AM = AM;
            this.Correo = Correo;
            this.Docente = Docente;

        }
        private void conectar()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=LAPTOP-1PDV9BUI\\SQLEXPRESS; Initial Catalog=tutoria;Integrated Security = True;";
            try
            {
                con.Open();
            }
            catch (Exception ex)
            { }
        }

        public void operacion(int i)
        {
            this.conectar();
            string CMD;
            SqlCommand CMDSQL = new SqlCommand();
            CMDSQL.CommandType = CommandType.StoredProcedure;
            CMD = "spAsignacion";
            CMDSQL.CommandText = CMD;
            CMDSQL.Connection = this.con;
        
            CMDSQL.Parameters.Add("@metodo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@metodo"].Value = i;
   
            CMDSQL.Parameters.Add("@Codigo", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Codigo"].Value = this.Codigo;

            CMDSQL.Parameters.Add("@Nombres", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Nombres"].Value = this.Nombres;

            CMDSQL.Parameters.Add("@AP", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@AP"].Value = this.AP;

            CMDSQL.Parameters.Add("@AM", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@AM"].Value = this.AM;

            CMDSQL.Parameters.Add("@Correo", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Correo"].Value = this.Correo;

            CMDSQL.Parameters.Add("@Docente", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Docente"].Value = this.Docente;

            CMDSQL.ExecuteNonQuery();

        }
        public DataTable consultar(int i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " exec spAsignacion " + i + ",'" + this.Codigo + "','" + this.Nombres + "','" + this.AP + "','" + this.AM + "','" + this.Correo + "','" + this.Docente + "'";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
                da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }

        public DataTable consultardocente(string dato)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS+
            string B = "select * from Asignacion where Docente = '" + dato + "'";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }

      
    }
}
