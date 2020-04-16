using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace inversionesBurgos
{
    class Dato
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-S2UC465\\SQLEXPRESS;Initial Catalog=InversionesBurgos;Integrated Security=True");
        SqlCommand comando;
  

        //metodo
        public void Guardar(int cedu, string nom, string apelli, string apellidos, string sexo, string edad, string direcc, string fecha, string nacimien, string civil, string prestamo,string imagen)
        {
            conn.Open();
            string lineaComando = $"insert into Burgos values( {cedu},'{nom}','{apelli}' ,'{apellidos}','{sexo}' ,{edad} ,'{direcc}','{fecha}','{nacimien}','{civil}','{prestamo}','{imagen}' )";
            comando = new SqlCommand(lineaComando, conn);
            comando.ExecuteNonQuery();
            conn.Close();      
                                      
                   
             

        }
        public void Actualizar(int cedu, string nom, string apelli, string apellidos, string sexo, string edad, string direcc, string fecha, string nacimien, string civil, string prestamo, string imagen)
        {
            conn.Open();
            string lineaComando = $"update Burgos set Nombre='{nom}', Apellido='{apelli}', Apellidos='{apellidos}', Sexo='{sexo}', Edad='{edad}' Direccion='{direcc}', Fecha='{fecha}',Nacimiento='{nacimien}', Civil ='{civil}', Prestamo='{prestamo}', Imagen='{imagen}' where Cedula= {cedu}";
            comando = new SqlCommand(lineaComando, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }
        public void Borrar(int cedu)
        {
            conn.Open();
            string lineaComando = $"delete from Burgos where Cedula = '{cedu}'";
            comando = new SqlCommand(lineaComando, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable LlenarGrid()
        {
            conn.Open();
            string lineaComando = "select * from Burgos";
            comando = new SqlCommand(lineaComando, conn);

            comando.ExecuteNonQuery();
         
            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            conn.Close();

            return table;

        }
        public DataTable Buscar(int cedu)
        {
            conn.Open();
            string lineaComando = $"select * from Burgos where Cedula = {cedu}";
            comando = new SqlCommand(lineaComando, conn);

            comando.ExecuteNonQuery();
           
            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            conn.Close();

            return table;

        }
       

    }
}
