using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace Bank_DataAccess
{
    public static class clsUsersData
    {

        public static bool GetUsersInfoByUserID(int UserID, ref string UserName, ref string FirstName
                 , ref string LastName, ref string Phone, ref string Email, ref string Password)
        {

            bool IsFound = false;


            try
            {
                {

                    using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                    {

                        Connection.Open();

                        string Query = @"SELECT * FROM Users where UserID=@UserID";



                        using (SqlCommand Command = new SqlCommand(Query, Connection))
                        {

                            Command.Parameters.AddWithValue("@UserID", UserID);

                            using (SqlDataReader Reader = Command.ExecuteReader())
                            {
                                if (Reader.Read())
                                {

                                    IsFound = true;

                                    UserName = (string)Reader["UserName"];
                                    FirstName = (string)Reader["FirstName"];
                                    LastName = (string)Reader["LastName"];
                                    Phone = (string)Reader["Phone"];
                                    Email = (string)Reader["Email"];
                                    Password = (string)Reader["Password"];

                                }
                                else
                                {
                                    IsFound = false;

                                }

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

        public static int AddNewUsers(string UserName, string FirstName
    , string LastName, string Phone, string Email, string Password)
        {
            int UserID = -1;


            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    Connection.Open();


                    string Query = @"INSERT INTO Users (UserName,FirstName,LastName,Phone,Email,Password)
                          VALUES (@UserName,@FirstName,@LastName,@Phone,@Email,@Password)
                                 SELECT SCOPE_IDENTITY();";

                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {


                        Command.Parameters.AddWithValue("@UserName", UserName);
                        Command.Parameters.AddWithValue("@FirstName", FirstName);
                        Command.Parameters.AddWithValue("@LastName", LastName);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Password", Password);


                        object Result = Command.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                        {
                            UserID = InsertedID;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            return UserID;
        }



        public static bool UpdateUsers(int UserID, string UserName, string FirstName
, string LastName, string Phone, string Email, string Password)
        {


            int RowAffected = 0;


            try
            {


                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    Connection.Open();

                    string Query = @"Update Users
                      set UserName =@UserName,
                          FirstName=@FirstName,
                          LastName =@LastName,
                          Phone=@Phone,
                          Email=@Email,
                          Password=@Password
                          where UserID=@UserID";


                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {

                        Command.Parameters.AddWithValue("@UserID", UserID);
                        Command.Parameters.AddWithValue("@UserName", UserName);
                        Command.Parameters.AddWithValue("@FirstName", FirstName);
                        Command.Parameters.AddWithValue("@LastName", LastName);
                        Command.Parameters.AddWithValue("@Phone", Phone);
                        Command.Parameters.AddWithValue("@Email", Email);
                        Command.Parameters.AddWithValue("@Password", Password);

                        RowAffected = Command.ExecuteNonQuery();

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            return (RowAffected > 0);
        }
        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();



            try
            {


                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    Connection.Open();

                    string Query = @"SELECT * FROM Users ";

                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }

                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            return dt;
        }
        public static bool GetUserNameAndPassword(string UserName, string Password, ref int UserID, ref string FirstName
            , ref string LastName, ref string Phone, ref string Email)
        {

            bool IsFound = false;

            try
            {

                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {

                    Connection.Open();

                    string Query = "SELECT * from Users where UserName=@UserName and Password=@Password";


                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {

                        Command.Parameters.AddWithValue("@UserName", UserName);
                        Command.Parameters.AddWithValue("@Password", Password);


                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {

                            if (Reader.Read())
                            {

                                IsFound = true;

                                UserID = (int)Reader["UserID"];
                                FirstName = (string)Reader["FirstName"];
                                LastName = (string)Reader["LastName"];
                                Phone = (string)Reader["Phone"];
                                Email = (string)Reader["Email"];


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
        public static bool DeleteUser(int UserID)
        {

            int RowAffected = 0;

            using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {

                Connection.Open();

                string Query = "Delete Users where UserID=@UserID";

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {


                    Command.Parameters.AddWithValue("@UserID", UserID);


                    RowAffected = Command.ExecuteNonQuery();

                }


            }

            return RowAffected > 0;
        }
    
        public static DataTable  GetAllRows()
        {


            DataTable dt = new DataTable();

            try
            {


                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
                {




                    Connection.Open();

                    string Query = @"select count(*) from Users";

                    using (SqlCommand Command = new SqlCommand(Query, Connection))
                    {

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }






                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error :" + ex.Message);
            }
            return dt;
        }




    }
}
