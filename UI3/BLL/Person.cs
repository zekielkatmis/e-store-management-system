using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public abstract class Person
    {
        string name;
        string email;
        string passwrod;

        public Person()
        {

        }
        public Person(string name, string email, string passwrod)
        {
            this.name = name;
            this.email = email;
            this.passwrod = passwrod;
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => passwrod; set => passwrod = value; }

        public abstract int Login(string email, string password);


        public void Logout()
        {

        }

        public List<string> ShowAnnouncement()
        {
            return null;
        }
    }
}
