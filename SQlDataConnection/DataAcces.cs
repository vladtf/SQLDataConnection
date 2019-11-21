using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;

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
                try
                {
                    
                    if (lastName == "*")
                        return connection.Query<Person>($"select * from actor;").ToList();
                    else 
                        return connection.Query<Person>($"call actor_getByLastName('{ lastName }');").ToList();

                }
                catch
                {
                    MessageBox.Show("No DataBase Connection");
                    
                }

                return null; 
                
            }
        }

        //Insert a new person into the database
        public void InsertPerson(string first_name, string last_name, string id)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("sakilaDB")))
            {
                //List<Person> people = new List<Person>();
                //people.Add(new Person { first_name = first_name, last_name = last_name, actor_id = id });
                //connection.Execute($"actor_Insert @FirstName,@LastName,@id",people);
                int id_int=new int();
                try
                {
                    id_int = int.Parse(id);
                }
                catch { MessageBox.Show("Wrong format id."); }

                try 
                { 
                    connection.Execute($"call actor_Insert('{first_name}','{last_name}',{id_int});"); 
                }
                catch
                {
                    MessageBox.Show("ID already used.");
                }
                

            }
        }

        public void DeletPerson(string id)
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("sakilaDB")))
            {
                int id_int = new int();
                try
                {
                    id_int = int.Parse(id);
                    connection.Execute($"call actor_deleteById({id_int});");
                }
                catch { MessageBox.Show("Wrong format id."); }

            }
        }
    }
}