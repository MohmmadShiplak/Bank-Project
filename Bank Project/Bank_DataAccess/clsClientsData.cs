using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DataAccess
{
    public class clsClientsData
    {
        public static bool GetClientsInfoByID(int ClientID, ref string ClientName, ref string AccountNumber
               , ref decimal AccountBalance, ref string Phone, ref string Pincode,ref string ImagePath)
        {

            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring);





            string Query = @"SELECT * from Clients where ClientID=@ClientID";


            SqlCommand Commnad = new SqlCommand(Query, Connection);

            Commnad.Parameters.AddWithValue("@ClientID", ClientID);



            try
            {

                Connection.Open();

                SqlDataReader Reader = Commnad.ExecuteReader();



                if (Reader.Read())
                {


                    IsFound = true;



                    ClientName = (string)Reader["ClientName"];

                    AccountNumber = (string)Reader["AccountNumber"];


                    AccountBalance = (decimal)Reader["AccountBalance"];


                    Phone = (string)Reader["Phone"];

                    Pincode = (string)Reader["PinCode"];


                    if (Reader["ImagePath"] != DBNull.Value)
                    {

                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();
            }


            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }

            return IsFound;
        }
        static public int AddNewClients(string ClientName, string  AccountNumber, decimal ? AccountBalance,
             string Phone, string PinCode,string ImagePath)
        {

            int  ClientID  = -1;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            Connection.Open();  



            SqlCommand Command = new SqlCommand("SP_AddNewClients", Connection);

            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("@ClientName", ClientName);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            Command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@PinCode", PinCode);


            if (ImagePath != "" && ImagePath != null)
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            //if (AccountBalance != -1 && AccountBalance != null)
            //    Command.Parameters.AddWithValue(@"AccountBalance", AccountBalance);
            //else
            //    Command.Parameters.AddWithValue(@"AccountBalance", System.DBNull.Value);

            SqlParameter OutPutClientID = new SqlParameter("@ClientID", SqlDbType.Int)//Type of output parameter 
            {

                Direction = ParameterDirection.Output
            };
            Command.Parameters.Add(OutPutClientID);
            Command.ExecuteScalar();
            ClientID = (int)OutPutClientID.Value;

        
            try
            {


                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return ClientID;
        }
        static public bool UpdatClients(int ClientID, string ClientName, string AccountNumber, decimal AccountBalance,
              string Phone, string PinCode,string ImagePath)
        {

            int RowAffected = 0;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring);





            SqlCommand Command = new SqlCommand("SP_UpdateClients", Connection);

            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@ClientName", ClientName);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            Command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@PinCode", PinCode);


            if (ImagePath != "" && ImagePath != null)
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);




            try
            {

                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return (RowAffected > 0);
        }
        public static bool GetClientsInfoByAccountNumber(ref int ClientID, ref string ClientName, string AccountNumber
              , ref decimal AccountBalance, ref string Phone, ref string Pincode,ref string ImagePath)
        {

            bool IsFound = false;



            try
            {



                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    Connection.Open();


                    string Query = @"SELECT * from Clients where AccountNumber=@AccountNumber";

                    using (SqlCommand Commnad = new SqlCommand(Query, Connection))
                    {


                        Commnad.Parameters.AddWithValue("@AccountNumber",AccountNumber);


                        using (SqlDataReader Reader = Commnad.ExecuteReader())
                        {

                            if (Reader.Read())
                            {


                                IsFound = true;

                                ClientName = (string)Reader["ClientName"];

                                ClientID = (int)Reader["ClientID"];


                                AccountBalance = (decimal)Reader["AccountBalance"];


                                Phone = (string)Reader["Phone"];

                                Pincode = (string)Reader["PinCode"];

                                if (Reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)Reader["ImagePath"];
                                }
                                else
                                {
                                    ImagePath = "";
                                }



                            }

                            else
                            {
                                IsFound = false;
                            }


                        }
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            return IsFound;
        }
        public static bool DeleteClient(int ClientID)
        {


            int RowAffected = 0;


            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {


                    connection.Open();

                    string Query=@"delete Clients 
                                  where ClientID=@ClientID";
                        
                        
                    using(SqlCommand Command=new SqlCommand(Query,connection))
                    {


                        Command.Parameters.AddWithValue("@ClientID", ClientID);



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
        public static DataTable GetAllClients()
        {


            DataTable dt = new DataTable();


            try
            {


                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    Connection.Open();

                    string Query = "SELECT * from Clients ";

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
                }
               

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error "+ex.Message);
            }
            return dt;
}




    }
  
}
