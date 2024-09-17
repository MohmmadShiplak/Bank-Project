using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DataAccess
{
    public static class clsCurrencyData
    {

        public static bool GetCurrencyInfobyCurrencyID(int CurrencyID, ref int CountryID, ref string Code
            , ref string Name, ref decimal Rate)
        {

            bool IsFound = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {

                Connection.Open();

                string Query = @"Select * from Currencies where CurrencyID=@CurrencyID";

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {


                    Command.Parameters.AddWithValue("@CurrencyID", CurrencyID);


                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {


                        if (Reader.Read())
                        {

                            IsFound = true;

                            CountryID = (int)Reader["CountryID"];
                            Code = (string)Reader["Code"];
                            Name = (string)Reader["Name"];
                            Rate = (decimal)Reader["Rate"];
                        }

                    }
                }
                return IsFound;
            }
        }
        public static bool GetCurrencyInfobyCode(ref int CurrencyID, ref int CountryID, string Code
          , ref string Name, ref decimal Rate)
        {

            bool IsFound = false;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {

                Connection.Open();

                string Query = @"Select * from Currencies where Code=@Code";

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {


                    Command.Parameters.AddWithValue("@Code", Code);


                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {


                        if (Reader.Read())
                        {

                            IsFound = true;

                            CurrencyID = (int)Reader["CurrencyID"];
                            CountryID = (int)Reader["CountryID"];
                            Name = (string)Reader["Name"];
                            Rate = (decimal)Reader["Rate"];
                        }

                    }
                }
                return IsFound;
            }
        }
        public static int AddNewCurrencies(int CountryID, string Code, string Name, decimal ?  Rate)
        {

            int CurrencyID = -1;


            try
            { 

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {

                Connection.Open();

                string Query = @"INSERT INTO Currencies (CountryID,Code,Name,Rate)
                              VALUES (@CountryID,@Code,@Name,@Rate);
                                 SELECT SCOPE_IDENTITY();";

                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {

                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        Command.Parameters.AddWithValue("@Code", Code);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Rate", Rate);

                        object Result = Command.ExecuteScalar();


                        if (Result != null && int.TryParse(Result.ToString(), out int Inserted))
                        {
                            CurrencyID = Inserted;
                        }

                    }
                   
                }
              
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return CurrencyID;
        }
        public static bool UpdateCurrencies(int CurrencyID, int CountryID, string Code, string Name, decimal  Rate)
        {

            int RowAffected = 0;


            try

            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    Connection.Open();

                    string Query = @"UPDATE Currencies 
                               SET CountryID=@CountryID,
                                   Code=@Code,
                                   Name=@Name,
                                   Rate=@Rate
                                   where CurrencyID=@CurrencyID";


                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {

                        Command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                        Command.Parameters.AddWithValue("@CountryID", CountryID);
                        Command.Parameters.AddWithValue("@Code", Code);
                        Command.Parameters.AddWithValue("@Name", Name);
                        Command.Parameters.AddWithValue("@Rate", Rate);


                        RowAffected = Command.ExecuteNonQuery();

                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            return RowAffected > 0;
        }

        public static DataTable GetAllCurrencies()
        {

            DataTable dt = new DataTable();


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {


                Connection.Open();

                string Query = "SELECT * FROM Currencies";

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {


                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {


                        if (Reader.HasRows)
                        {
                            dt.Load(Reader);
                        }

                    }

                }
                return dt;

            }

        }

        public static bool DeleteCurrency(int CurrencyID)
        {

            int RowAffected = 0;


            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                Connection.Open();

                string Query = "delete Currencies where CurrencyID=@CurrencyID";


                using (SqlCommand Commnad = new SqlCommand(Query, Connection))
                {

                    Commnad.Parameters.AddWithValue("@CurrencyID", CurrencyID);

                    RowAffected = Commnad.ExecuteNonQuery();
                }
            }

            return RowAffected > 0;
        }
    
 







    }
}
