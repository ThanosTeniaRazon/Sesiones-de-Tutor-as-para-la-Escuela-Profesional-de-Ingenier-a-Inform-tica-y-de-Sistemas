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
    class CMatricula
    {
        private int codigo_matricula;
        private int documento;
        private int codigo;
          private SqlConnection con;

        public CMatricula (int codigo_matricula,int documento,int codigo )
        {

            this.codigo_matricula = codigo_matricula;
            this.documento = documento;
            this.codigo = codigo;
        }
        private void conectar()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=LAPTOP-1PDV9BUI\\SQLEXPRESS; Initial Catalog=db_academico;Integrated Security = True;";
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
            CMD = "spTmatricula";
            CMDSQL.CommandText = CMD;
            CMDSQL.Connection = this.con;
            // @metodo int,
            CMDSQL.Parameters.Add("@metodo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@metodo"].Value = i;
            //@codigo_matricula
            CMDSQL.Parameters.Add("@codigo_matricula", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@codigo_matricula"].Value = this.codigo_matricula;
            //@documento
            CMDSQL.Parameters.Add("@documento", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@documento"].Value = this.documento;
            //@codigo
            CMDSQL.Parameters.Add("@codigo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@codigo"].Value = this.codigo;
           


            CMDSQL.ExecuteNonQuery();

        }
        public DataTable consultar(int i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " exec spTmatricula " + i + ",'" + this.codigo_matricula + "','" + this.documento + "','" + this.codigo + "'";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }



















    }
}
