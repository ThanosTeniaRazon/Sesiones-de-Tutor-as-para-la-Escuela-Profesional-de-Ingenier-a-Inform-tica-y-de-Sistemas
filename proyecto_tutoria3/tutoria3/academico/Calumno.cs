using System;
using System.Data;
using System.Data.SqlClient;

namespace academico
{
    class Calumno
    {
        private string Codigo;
        private string Nombres;
        private string AP;
        private string AM;
        private string Correo;

        private SqlConnection con;

        public Calumno(string Codigo, string Nombres, string AP, string AM, string Correo)
        {

            this.Codigo = Codigo;
            this.Nombres = Nombres;
            this.AP = AP;
            this.AM = AM;
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

        public void operacion(int i)
        {
            this.conectar();
            string CMD;
            SqlCommand CMDSQL = new SqlCommand();
            CMDSQL.CommandType = CommandType.StoredProcedure;
            CMD = "spAlumno";
            CMDSQL.CommandText = CMD;
            CMDSQL.Connection = this.con;
            // @metodo int,
            CMDSQL.Parameters.Add("@metodo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@metodo"].Value = i;
            //@id_intitucion
            CMDSQL.Parameters.Add("@Codigo", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Codigo"].Value = this.Codigo;
            //@descripcion varchar(max),
            CMDSQL.Parameters.Add("@Nombres", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Nombres"].Value = this.Nombres;
            //@direccion varchar(max)
            CMDSQL.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@AP"].Value = this.AP;
            //,@responsable varchar(max),
            CMDSQL.Parameters.Add("@AM", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@AM"].Value = this.AM;

            //@cod_carrera
            CMDSQL.Parameters.Add("@Correo", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@Correo"].Value = this.Correo;

            CMDSQL.ExecuteNonQuery();

        }
        public DataTable consultar(int i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " exec spAlumno " + i + ",'" + this.Codigo + "','" + this.Nombres + "','" + this.AP + "','" + this.AM + "','" + this.Correo + "'";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }

        public DataTable consultarAlumno()
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " select * from Alumno ";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }


    }
}
