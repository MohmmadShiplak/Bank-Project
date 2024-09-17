using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Business
{
   public   class clsCurrency
    {


       public enum enMode { AddNew=0,UpdateNew=1 };

       public enMode _Mode;
       public int CurrencyID { get; set; }
       public  int CountryID { get; set; }

       public string Name { get; set; }

       public string Code { get; set; }

       public decimal Rate { get; set; }

        public clsCountry CountryInfo;


        public clsCurrency()
        {

            this.CurrencyID = -1;
            this.CountryID = -1;
            this.Code = "";
            this.Rate = 0;

            _Mode = enMode.AddNew;
        }

        public clsCurrency(int CurrencyID,int CountryID,string Code,string Name,decimal Rate)
        {

            this.CurrencyID = CurrencyID;
            this.CountryID = CountryID;
            this.Code = Code;
            this.Name = Name;
            this.Rate = Rate;
            this.CountryInfo = clsCountry.Find(CountryID);

            _Mode = enMode.UpdateNew;

        }
      public bool AddNewCurrency()
        {
            this.CurrencyID = clsCurrencyData.AddNewCurrencies(this.CountryID, this.Code
                , this.Name, this.Rate);

            return (this.CurrencyID != -1);
        }
       public bool UpdateCurrency()
        {
            return clsCurrencyData.UpdateCurrencies(this.CurrencyID, this.CountryID
                , this.Code, this.Name, this.Rate);
        }
        public bool Save()
        {


            switch(_Mode)
            {

                case enMode.AddNew:
                    if(AddNewCurrency())
                    {

                  
                        _Mode = enMode.UpdateNew;
                        return true;


                    }
                    else
                    {
                        return false;

                    }
                case enMode.UpdateNew:
                    return UpdateCurrency();

            }
            return false;
        }

        public static  clsCurrency Find(int CurrencyID)
        {

            string  Code = "", Name = "";

            decimal Rate = 0;

            int Country = -1;

            bool IsFound = clsCurrencyData.GetCurrencyInfobyCurrencyID(CurrencyID, ref Country
                , ref Code, ref Name, ref Rate);

            if (IsFound)
            {
                return new clsCurrency(CurrencyID, Country, Code, Name, Rate);
            }
            else
            {
                return null;
            }

        }
        public static  clsCurrency Find(string Code)
        {

             string Name = "";


            int CountryID = -1;

            int CurrencyID = -1;


            decimal Rate = 0;


            bool IsFound = clsCurrencyData.GetCurrencyInfobyCode(ref CurrencyID,ref CountryID,Code,
                 ref Name, ref Rate);

            if (IsFound)
            {
                return new clsCurrency(CurrencyID, CountryID, Code, Name, Rate);
            }
            else
            {
                return null;
            }

        }
     
        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyData.GetAllCurrencies();
        }
        public static bool DeleteCurrency(int CurrencyID)
        {
            return clsCurrencyData.DeleteCurrency(CurrencyID);
        }




    }
}
