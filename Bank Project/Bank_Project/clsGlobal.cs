using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Business;
namespace Bank_Project
{
  public       class clsGlobal
    {

        public static clsUsers CurrentUser;


     
        internal class DbConfig
        {
            public static string ConnectionString = "data source =.; database=Library; integrated security = SSPI";
            public static string encodePassword(string plainText)
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            public static string decodePassword(string base64EncodedData)
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
        }
    }









}

