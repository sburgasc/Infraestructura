using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using Entidades;

namespace AccesoDatos
{
    public class PuertoAD
    {



        public List<PuertoE> listarPuertos()
        {
            List<PuertoE> puertos = new List<PuertoE>();

            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ADOConnectionString"].ToString()))
            {
                

            }
            return puertos;
        }
    }
}
