using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business
{
    public  class clsUsers
    {

        public enum enMode { AddNew = 0, UpdateNew = 1 }

        public enMode _Mode = enMode.AddNew;

        public int UserID { get; set; }
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        public clsUsers(int UserID, string UserName, string FirstName, string LastName
            , string Phone, string Email, string Password)
        {

            this.UserID = UserID;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Password = Password;

            _Mode = enMode.UpdateNew;

        }
        public clsUsers()
        {

            this.UserID = -1;
            this.UserName = "";
            this.FirstName = "";
            this.LastName = "";
            this.Phone = "";
            this.Email = "";
            this.Password = "";

            _Mode = enMode.AddNew;

        }

        private bool _AddNewUsers()
        {

            this.UserID = clsUsersData.AddNewUsers(this.UserName, this.FirstName, this.LastName
                , this.Phone, this.Email, this.Password);

            return (this.UserID != -1);

        }
        private bool _UpdateUsers()
        {
            return clsUsersData.UpdateUsers(this.UserID, this.UserName, this.FirstName
                , this.LastName, this.Phone, this.Email, this.Password);
        }

        public bool Save()
        {

            switch (_Mode)
            {

                case enMode.AddNew:
                    if (_AddNewUsers())
                    {

                        _Mode = enMode.UpdateNew;

                        return true;

                    }
                    else
                    {
                        return false;

                    }
                case enMode.UpdateNew:
                    return _UpdateUsers();

            }
            return false;

        }
        static public clsUsers Find(int UserID)
        {

            string UserName = "", FirstName = "", LastName = "", Phone = "", Email = "", Password = "";

            if (clsUsersData.GetUsersInfoByUserID(UserID, ref UserName, ref FirstName, ref LastName
                , ref Phone, ref Email, ref Password))
                return new clsUsers(UserID, UserName, FirstName, LastName, Phone, Email, Password);
            else
                return null;

        }
        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }
        public static clsUsers Find(string UserName, string Password)
        {

            int UserID = -1;

            string FirstName = "", LastName = "", Phone = "", Email = "";

            if (clsUsersData.GetUserNameAndPassword(UserName, Password, ref UserID
                , ref FirstName, ref LastName, ref Phone, ref Email))
                return new clsUsers(UserID, UserName, FirstName, LastName, Phone, Email, Password);
            else
                return null;


        }
        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);
        }
        public static DataTable  GetAllRows()
        {
            return clsUsersData.GetAllRows();
        }


    }
}
