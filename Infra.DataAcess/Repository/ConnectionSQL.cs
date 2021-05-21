using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAcess.Repository
{
    public class ConnectionSQL
    {
        protected SqlConnection connection = new SqlConnection("Server=163.178.107.10 ;Database=architecture_N_Layers;User Id=laboratorios;Password=KmZpo.2796;");
    }
}
