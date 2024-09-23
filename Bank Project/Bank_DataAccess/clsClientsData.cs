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
               , ref decimal AccountBalance, ref string Phone, ref string Pincode, ref string ImagePath)
        {

            bool IsFound = false;



            try
            {

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {

                Connection.Open();

                    using (SqlCommand Commnad = new SqlCommand("SP_GetClientsInfobyClientID", Connection))
                    {

                        Commnad.CommandType = CommandType.StoredProcedure;

                        Commnad.Parameters.AddWithValue("@ClientID", ClientID);

                        using (SqlDataReader Reader = Commnad.ExecuteReader())
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
                    }

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("error "+ex.ToString());   
            }
            return IsFound;
        }



                











        static public int AddNewClients(string ClientName, string  AccountNumber, decimal ? AccountBalance,
             string Phone, string PinCode,string ImagePath)
        {

            int  ClientID  = -1;


            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_AddNewClients", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ClientName",(object) ClientName??DBNull.Value);
                        Command.Parameters.AddWithValue("@AccountNumber",(object) AccountNumber??DBNull.Value);
                        Command.Parameters.AddWithValue("@AccountBalance",(object) AccountBalance??DBNull.Value);
                        Command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@PinCode", (object)PinCode ?? DBNull.Value);


                    

                        SqlParameter OutPutClientID = new SqlParameter("@ClientID", SqlDbType.Int)//Type of output parameter 
                        {

                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(OutPutClientID);
                        Command.ExecuteScalar();
                        ClientID = (int)OutPutClientID.Value;

                    }

                }
                

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error "+ex.ToString());
            }
                 
            return ClientID;
        }
        static public bool UpdatClients(int ClientID, string ClientName, string AccountNumber, decimal AccountBalance,
              string Phone, string PinCode,string ImagePath)
        {

            int RowAffected = 0;


            try
            {



                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    using (SqlCommand Command = new SqlCommand("SP_UpdateClients", Connection))
                    {


                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@ClientID", (object)ClientID ?? DBNull.Value   );
                        Command.Parameters.AddWithValue("@ClientName", (object)ClientName ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@AccountNumber",(object)AccountNumber ?? DBNull.Value  );
                        Command.Parameters.AddWithValue("@AccountBalance", (object)AccountBalance ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                        Command.Parameters.AddWithValue("@PinCode", (object)PinCode ?? DBNull.Value);

                        RowAffected = Command.ExecuteNonQuery();


                    }


                }



            }
            catch(Exception ex)
            {
                Console.WriteLine("Error :"+ex.ToString());   
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


                    

                    using (SqlCommand Commnad = new SqlCommand("SP_GetClientsInfobyAccountNumber", Connection))
                    {


                        Commnad.Parameters.AddWithValue("@AccountNumber",AccountNumber);


                        using (SqlDataReader Reader = Commnad.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                ClientName = (Reader["ClientName"]!=DBNull.Value)? (string)Reader["ClientName"]:null;
                                ClientID = (int)Reader["ClientID"];
                                AccountBalance = (decimal)Reader["AccountBalance"];
                                Phone = (Reader["Phone"]!=DBNull.Value)? (string)Reader["Phone"]:null;
                                Pincode = (Reader["PinCode"] != DBNull.Value) ? (string)Reader["PinCode"] : null;
                                ImagePath = (Reader["PinCode"] != DBNull.Value) ? (string)Reader["PinCode"] : null;

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

                    using(SqlCommand Command=new SqlCommand("SP_DeleteClients", connection))
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

                  

                    using (SqlCommand Command = new SqlCommand("SP_GetAllClients", Connection))
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
