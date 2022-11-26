using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DeliveryCompany
{
    internal class BdConnect
    {
        private static string bdCon = "Data Source=DESKTOP-9HDCF87;Initial Catalog=DeliveryDatabase;Integrated Security=True";
        public static string connect
        {
            get { return bdCon; }
            set { bdCon = value; }
        }
        
    }
}
