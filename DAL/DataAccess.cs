using Dapper;
using SQLDataAccessDemo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLDataAccessDemo.Model;

namespace SQLDataAccessDemo.DAL
{
    public class DataAccess
    {
        public List<Person> Getpeople(string lastName)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
                {
                    //var result = connection.Query<Person>($"select * from People where LastName='{lastName}'").ToList();
                    var result = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                    // var result2=connection.
                    return result;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
                {
                    //var result = connection.Query<Person>($"select * from People where LastName='{lastName}'").ToList();

                    List<Person> people = new List<Person>();
                    people.Add(new Person { FirstName = "Tu", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu1", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu2", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu3", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu4", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu5", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu6", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu7", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu8", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    people.Add(new Person { FirstName = "Tu9", LastName = "Tran", EmailAddress = "tu@gmail.com", PhoneNumber = "123456" });
                    connection.Execute("[dbo].[People_Insert] @FirstName,@LastName,@EmailAddress,@PhoneNumber", people);

                    // var result2=connection.
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}