using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MyCalc
{
    public class DataAcces
    {
        //Create a list of PERSONS retrieved from database
        public List<Person> GetPeople(string lastName)
        {
            //create a new CONNECTION and destroy it after closing {}
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("sakilaDB")))
            {
                //sql statemnt to select data 
                //var output = connection.Query<Person>($"Select * from sakila.actor where last_name = '{lastName}'").ToList();
                var output = connection.Query<Person>($"call actor_getByLastName('{ lastName }');").ToList();

                return output;
            }
        }
    }
}