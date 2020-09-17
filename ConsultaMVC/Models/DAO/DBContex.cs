using System.Data.SqlClient;

namespace ConsultaMVC.Models.DAO
{
    class DBContex
    {
        protected SqlConnection con = new SqlConnection("Server=DANTES\\DANTES;DataBase=Practica_Patrones;Integrated Security=true");
    }
}
