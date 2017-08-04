using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BTL
{
    class ConnectionString
    {
        public static string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        }
    }
}
