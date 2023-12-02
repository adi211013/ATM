using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_library
{
    public class User
    {
        public int id=0;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public decimal Balance;


        public User(string firstName,string lastName,string email,string password) 
        {
            FirstName= firstName;
            LastName= lastName;
            Email= email;
            Password = password;
            Balance = 0;
        }
        public override string ToString()
        {
            return $"{id} {FirstName} {LastName} {Email} {Password} {Balance}";
        }
        public User(string email,string password)
        {
            Email = email;
            Password = password;
        }

    }
}
