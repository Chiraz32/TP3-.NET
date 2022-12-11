using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace tp3.Models
{
    public class PersonalInfo
    {
        List<Person> persons = new List<Person>();
        Person person = new Person();
        public List<Person> GetAllPerson()
        {
            SQLiteConnection dbCon = new SQLiteConnection(@"Data source=C:\Users\dossc\source\repos\tp3\tp3\bin\SQLite database.db");
            dbCon.Open();
            Debug.WriteLine("database opening ...");
            using (dbCon)
            {
                SQLiteCommand command = new SQLiteCommand(
                       "SELECT * FROM personal_info", dbCon);
                SQLiteDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Person person = new Person((int)reader["id"], (string)reader["first_name"], (string)reader["last_name"], (string)reader["email"],  (string)reader["image"], (string)reader["country"]);

                        persons.Add(person);

                    }
                }
            }
            return persons;
        }
        public Person GetPersonById(int id)
        {

            SQLiteConnection dbCon = new SQLiteConnection(@"Data source=C:\Users\dossc\source\repos\tp3\tp3\bin\SQLite database.db");
            dbCon.Open();
            Debug.WriteLine("database opening ...");
            using (dbCon)
            {
                SQLiteCommand command = new SQLiteCommand(
                       "SELECT * FROM personal_info WHERE id=@id", dbCon);

                command.Parameters.Add(new SQLiteParameter("@id", id));
                SQLiteDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    reader.Read();

                    Debug.WriteLine("reading ...");
                    if (reader.HasRows)
                    {
                        person = new Person((int)reader["id"], (string)reader["first_name"], (string)reader["last_name"], (string)reader["email"],(string)reader["image"], (string)reader["country"]);
                    }
                    else { person = new Person(); }
                   
                    Debug.WriteLine("Person " + person.ToString());



                }
            }
            return person;



        }
    }
}