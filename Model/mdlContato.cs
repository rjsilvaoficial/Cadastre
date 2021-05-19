using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class mdlContato
    {
        public long cpf { get; set; } 
        public string nome { get; set; }
        public long telefone { get; set; }
        
    }
}
