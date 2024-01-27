using System;
using System.Data;
using System.Data.SqlClient;

namespace academico
{
    class Cdocente
    {
        private string CodigoDocentes;
        private string Nombre;
        private string Paterno;
        private string Materno;
        private string Correo;

        private SqlConnection con;

        public Cdocente(string CodigoDocentes, string Nombre, string Paterno, string Materno, string Correo)
        {
            this.CodigoDocentes = CodigoDocentes;
            this.Nombre = Nombre;
            this.Paterno = Paterno;
            this.Materno = Materno;
            this.Correo = Correo;
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

        //convertir cualquier imagen en tipo byte

        public void operacion(int i)
        {
            this.conectar();
            string CMD;
            SqlCommand CMDSQL = new SqlCommand();
            CMDSQL.CommandType = CommandType.StoredProcedure;
            CMD = "spDocentes";
            CMDSQL.CommandText = CMD;
            CMDSQL.Connection = this.con;

            CMDSQL.Parameters.Add("@metodo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@metodo"].Value = i;

            CMDSQL.Parameters.Add("@CodigoDocentes", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@CodigoDocentes"].Value = this.CodigoDocentes;

            CMDSQL.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Nombre"].Value = this.Nombre;

            CMDSQL.Parameters.Add("@Paterno", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Paterno"].Value = this.Paterno;

            CMDSQL.Parameters.Add("@Materno", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Materno"].Value = this.Materno;

            CMDSQL.Parameters.Add("@Correo", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Correo"].Value = this.Correo;

            CMDSQL.ExecuteNonQuery();

        }
        public DataTable consultar(int i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " exec spDocentes " + i + ",'" + this.CodigoDocentes + "','" + this.Nombre + "','" + this.Paterno + "','" + this.Materno + "','" + this.Correo + "'";
            
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }
    }
}
