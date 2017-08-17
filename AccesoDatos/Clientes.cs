using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using Entidades;

public class Clientes
{
	
        public List<ClienteE> listarClientes()
        {
            List<ClienteE> cliente = new List<ClienteE>();

            using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ADOConnectionString"].ToString()))
            {


            }
            return cliente;
        }

    
}
