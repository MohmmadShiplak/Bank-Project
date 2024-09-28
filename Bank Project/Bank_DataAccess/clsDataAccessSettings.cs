
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;



namespace Bank_DataAccess
{
    public static   class clsDataAccessSettings
    {
        public static string Connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
           // "Server=.;database=Bank Project ;User Id=sa;Password=sa123456";

         
    }
}
