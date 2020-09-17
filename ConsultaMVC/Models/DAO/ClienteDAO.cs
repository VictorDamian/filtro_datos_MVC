using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConsultaMVC.Models.DTO;
 
namespace ConsultaMVC.Models.DAO
{
    class ClienteDAO:DBContex
    {
        SqlDataReader LeerFilas;
        SqlCommand Comando = new SqlCommand();
        //METODOS CRUD
        //no es recomendable usar DataTable ya que consume mucha RAM
        //es mejor usar metodos serializables
        public List<ClienteDTO> verRegistros(string Condicion)
        {
            Comando.Connection = con;
            Comando.CommandText = "verRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);

            con.Open();

            LeerFilas = Comando.ExecuteReader();
            List<ClienteDTO> ListaGenereica = new List<ClienteDTO>();//lista generica
            //DICCIONARIO
            //SERIALIZACION: XML, JSON, NATIVA
            while (LeerFilas.Read())//agregar
            {
                ListaGenereica.Add(new ClienteDTO
                {
                    ID = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            con.Close();
            return ListaGenereica;
        }
        public void Insertar() { }
        public void Eliminar() { }
        public void Editar() { }
    }
}
