using System;
using System.Data;
using System.Data.SqlClient;

namespace academico
{
    class Ctutoria
    {
        private string Codigo;
        private string Fecha;
        private string Hora;
        private string Tema;
        private string Asistencia;

        private SqlConnection con;

        public Ctutoria(string Codigo, string Fecha,string Hora, string Tema, string Asistencia)
        {
            this.Codigo = Codigo;
            this.Fecha = Fecha;
            this.Hora = Hora;
            this.Tema = Tema;
            this.Asistencia = Asistencia;
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
            CMD = "spTutoria";
            CMDSQL.CommandText = CMD;
            CMDSQL.Connection = this.con;

            CMDSQL.Parameters.Add("@metodo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@metodo"].Value = i;

            CMDSQL.Parameters.Add("@Codigo", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Codigo"].Value = this.Codigo;

            CMDSQL.Parameters.Add("@Fecha", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Fecha"].Value = this.Fecha;

            CMDSQL.Parameters.Add("@Hora", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Hora"].Value = this.Hora;

            CMDSQL.Parameters.Add("@Fecha", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Fecha"].Value = this.Fecha;

            CMDSQL.Parameters.Add("@Tema", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Tema"].Value = this.Tema;

            CMDSQL.Parameters.Add("@Asistencia", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Asistencia"].Value = this.Asistencia;

            CMDSQL.ExecuteNonQuery();

        }
        public DataTable consultar(int i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " exec spTutoria " + i + ",'" + this.Codigo + "','" + this.Fecha + "','" + this.Hora + "','" + this.Tema + "','" + this.Asistencia + "'";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }
        public DataTable buscar(string i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = "select * from tutoria where Codigo like ('"+i+"%')";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }
            

    }
}
