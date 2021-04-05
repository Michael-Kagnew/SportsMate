using SportsMate.Business_Layer.Data_Structures;
using SportsMate.Models;
using SportsMate.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsMate.Business_Layer.Business_Objects
{
    public abstract class Account
    {
        private DateTime _birthday;

        private static readonly  int MIN_AGE = 16;


        public string FirstName { get; private set; }

        public string LastName { get; set; }

        public string AlphaID { get; private set; }
        public DateTime Birthday {
            get { return _birthday; }

            private set {
                if(ValidateAgeofAccount(value) == false)
                {
                    throw new ArgumentException("This birthday is either too young or logically does not make sense");
                }
                else
                {
                    _birthday = value;
                }
            } 
        }

        public List<Equipment> Equipment { get; set; }

        public Account(string FirstName, string LastName, string Birthday)  
        {
            DateTime ActualBirthDate = DateTime.Parse(Birthday);
            try //If validateAgeOfAccount not used, then at least constructor will stop furtther execution
            {
                this.Birthday = ActualBirthDate;

            } catch(Exception e)
            {
                throw;
            }

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.AlphaID = Guid.NewGuid().ToString();
        }


        public int GetAge()
        {
            DateTime n = DateTime.Now; // To avoid a race condition around midnight
            int age = n.Year - Birthday.Year;

            if (n.Month < Birthday.Month || (n.Month == Birthday.Month && n.Day < Birthday.Day))
                age--;

            return age;
        }

       
        public static Boolean ValidateAgeofAccount(DateTime birthdate)
        {
            if (birthdate == null)
            {
                throw new NullReferenceException("null date in the age of account validation");
            }

            if (!UserInputValidator.ValidateDateLessThanCurrent(birthdate) ||  CalculateAge(birthdate) < MIN_AGE)
            {
                return false;
            } else 
            {
                return true;
            }
        }


        private static int CalculateAge(DateTime birthdate)
        {
            DateTime n = DateTime.Now; // To avoid a race condition around midnight
            int age = n.Year - birthdate.Year;

            if (n.Month < birthdate.Month || (n.Month == birthdate.Month && n.Day < birthdate.Day))
                age--;

            return age;
        }

    }
}
