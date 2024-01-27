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
    class Ccarrera
    {
        private int codigo_carrera;
        private string nombre_carrera;


        private SqlConnection con;

        public Ccarrera(int codigo_carrera,string nombre_carrera)
    {
            this.codigo_carrera = codigo_carrera;
            this.nombre_carrera = nombre_carrera;
            
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

        //convertir cualquier imagen en tipo byte

        private byte[] ImageToByte(Image pImagen)
        {
            byte[] mImage;//VARIABLE BYTE DE RESULTADO
            MemoryStream ms = new MemoryStream();//recorrer el fichero o archivo de imagen
            pImagen.Save(ms, pImagen.RawFormat);//agregando al memory stream el archivo  respetando su formato
            mImage = ms.GetBuffer();//guardamos en formato byte el rsultado del memory stream
            ms.Close();
            return mImage;

        }

        public void operacion(int i)
        {
            this.conectar();
            string CMD;
            SqlCommand CMDSQL = new SqlCommand();
            CMDSQL.CommandType = CommandType.StoredProcedure;
            CMD = "spCarrera";
            CMDSQL.CommandText = CMD;
            CMDSQL.Connection = this.con;
            // @metodo int,
            CMDSQL.Parameters.Add("@metodo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@metodo"].Value = i;

            //@codigo_carrera
            CMDSQL.Parameters.Add("@codigo_carrera", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@codigo_carrera"].Value = this.codigo_carrera;
            //@nombre_carrera varchar(max),
            CMDSQL.Parameters.Add("@nombre_carrera", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@nombre_carrera"].Value = this.nombre_carrera;
            


            CMDSQL.ExecuteNonQuery();

        }
        public DataTable consultar(int i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " exec spCarrera " + i + ",'" + this.codigo_carrera + "','" + this.nombre_carrera + "'" ;
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }





    }
    
    
}
