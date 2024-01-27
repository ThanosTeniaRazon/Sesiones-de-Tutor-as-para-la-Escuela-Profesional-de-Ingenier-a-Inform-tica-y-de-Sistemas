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
    class Calumno
    {
        private int documento;
        private string nombre;
        private string apellidos;
        private string direccion;
        private int cod_carrera;
        private Image foto;

        private SqlConnection con;

        public Calumno(int documento, string nombre, string apellidos, string direccion, int cod_carrera, Image foto)
        {
       
            this.documento = documento;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            
            this.cod_carrera=cod_carrera;
            this.foto = foto;
        }
        private void conectar()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=db_academico;User Id=sa;Password=1234;";
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
            CMD = "spAlumno";
            CMDSQL.CommandText = CMD;
            CMDSQL.Connection = this.con;
            // @metodo int,
            CMDSQL.Parameters.Add("@metodo", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@metodo"].Value = i;
            //@id_intitucion
            CMDSQL.Parameters.Add("@documento", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@documento"].Value = this.documento;
            //@descripcion varchar(max),
            CMDSQL.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@nombre"].Value = this.nombre;
            //@direccion varchar(max)
            CMDSQL.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@apellidos"].Value = this.apellidos;
            //,@responsable varchar(max),
            CMDSQL.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar);
            CMDSQL.Parameters["@direccion"].Value = this.direccion;
            
            //@cod_carrera
            CMDSQL.Parameters.Add("@cod_carrera", System.Data.SqlDbType.Int);
            CMDSQL.Parameters["@cod_carrera"].Value = this.cod_carrera;


            //@logo foto
            CMDSQL.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            CMDSQL.Parameters["@foto"].Value = ImageToByte(this.foto);


            CMDSQL.ExecuteNonQuery();

        }
        public DataTable consultar(int i)
        {
            this.conectar();//invoco a lA CONEXION
            DataTable Tabla = new DataTable();//declaro un data table(contenedor de datos)
            //para obtener los dATOS DE LA BASE DE DATOS
            string B = " exec spAlumno " + i + ",'" + this.documento + "','" + this.nombre + "','" + this.apellidos + "','" + this.direccion + "','" + this.cod_carrera + "','" 
                + this.foto + "'";
            SqlDataAdapter da = new SqlDataAdapter(B, this.con);
            da.Fill(Tabla);//llevamos los datos
            return Tabla;//le damos un valor a uncion
        }


    

    }
}
