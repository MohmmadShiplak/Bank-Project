using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business
{
    public class clsClients
    {
        public enum enMode { AddNew = 0, UpdateNew = 1 };

        public enMode _Mode = enMode.AddNew;




        public int ClientID { set; get; }

        public string ClientName { get; set; }

        public string AccountNumber { get; set; }

        public decimal AccountBalance { get; set; }

        public string Phone { set; get; }


        public string PinCode { get; set; }

        public string ImagePath { get; set; }

        public clsClients(int ClientID, string ClientName, string AccountNumber
            , string Phone, decimal AccountBalance, string PinCode,string ImagePath)
        {

            this.ClientID = ClientID;
            this.ClientName = ClientName;
            this.AccountNumber = AccountNumber;
            this.AccountBalance = AccountBalance;
            this.Phone = Phone;
            this.PinCode = PinCode;
            this.ImagePath = ImagePath;

            _Mode = enMode.UpdateNew;


        }

        public clsClients()
        {
            this.ClientID = -1;
            this.ClientName = "";
            this.AccountNumber = "";
            this.Phone = "";
            this.AccountBalance = 0;
            this.PinCode = "";
            this.ImagePath = "";

            _Mode = enMode.AddNew;


        }











        private bool _AddNewClients()
        {
            this.ClientID = clsClientsData.AddNewClients(this.ClientName, this.AccountNumber, this.AccountBalance
                , this.Phone, this.PinCode,this.ImagePath);

            return (ClientID!=-1);
        }

        private bool _UpdateClients()
        {
            return clsClientsData.UpdatClients(this.ClientID, this.ClientName, this.AccountNumber
                , this.AccountBalance, this.Phone, this.PinCode,this.ImagePath);
        }

        public bool Save()
        {

            switch (_Mode)
            {


                case enMode.AddNew:
                    if (_AddNewClients())
                    {
                        _Mode = enMode.UpdateNew;


                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.UpdateNew:
                    return _UpdateClients();

            }
            return false;
        }
        public static clsClients Find(int ClientID)
        {

            string ClientName = "", AccountNumber = "", Phone = "", PinCode = "",ImagePath="";

            decimal AccountBalance = -1;


            if (clsClientsData.GetClientsInfoByID(ClientID, ref ClientName, ref AccountNumber, ref AccountBalance, ref Phone, ref PinCode,ref ImagePath))
                return new clsClients(ClientID, ClientName, AccountNumber, Phone, AccountBalance, PinCode,ImagePath);
            else
                return null;

        }
        public static clsClients Find(string AccountNumber)
        {

            string ClientName = "",  Phone = "", PinCode = "",ImagePath="";

            decimal AccountBalance = -1;

            int ClientID = -1;



            if (clsClientsData.GetClientsInfoByAccountNumber(ref ClientID, ref ClientName,  AccountNumber, ref AccountBalance, ref Phone, ref PinCode,ref ImagePath))
                return new clsClients(ClientID, ClientName, AccountNumber, Phone, AccountBalance, PinCode, ImagePath);
            else
                return null;

        }
        public static bool DeleteClient(int ClientID)
        {
            return clsClientsData.DeleteClient(ClientID);
        }
        public static DataTable GetAllClients()
        {
            return clsClientsData.GetAllClients();
        }



    }


}

