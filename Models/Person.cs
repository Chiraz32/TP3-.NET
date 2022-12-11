using System;
using System.Web;

namespace tp3.Models
{
    public class Person 
    {
        int id ;
        string firstName;
        string lastName ;
        string email ;
      
        string image ;
        string country;

        public Person()
        {}

        public override string ToString()
        {
            return "person "+FirstName+" "+LastName+" " ;
        }

        public Person(int id, string firstName, string lastName, string email,string image, string country)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
           
            Image = image;
            Country = country;
        }

       

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }

        public string Image { get => image; set => image = value; }
        public string Country { get => country; set => country = value; }
        
    }
}
