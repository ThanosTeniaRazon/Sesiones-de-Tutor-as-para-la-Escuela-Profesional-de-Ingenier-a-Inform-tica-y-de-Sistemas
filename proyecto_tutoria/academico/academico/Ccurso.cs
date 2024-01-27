using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace academico
{
    class Ccurso
    {
        public int codigo;
        public string descripcion;

        public SqlConnection con;


        public Ccurso(int codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;


        }

        private void conectar()
        {
            con = new SqlConnection();
            string cadena = "Data Source=LAPTOP-1PDV9BUI\\SQLEXPRESS; Initial Catalog=ServicioElectrico;Integrated Security = True;";
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
            CMD = "spTcurso";
            CMDSQL.CommandText = CMD;
            CMDSQL.Connection = this.con;
            // @metodo int,
            CMDSQL.Parameters.Add("@metodo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@metodo"].Value = i;

            //@codigo
            CMDSQL.Parameters.Add("@codigo_carrera", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@codigo_carrera"].Value = this.codigo;
            //@descripcion varchar(max),
            CMDSQL.Parameters.Add("@nombre_carrera", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@nombre_carrera"].Value = this.descripcion;
        

            CMDSQL.ExecuteNonQuery();

        }

        public DataTable consultar(int i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " exec spTcurso " + i + ",'" + this.codigo + "','" + this.descripcion + "'";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion

        }



    }
}
