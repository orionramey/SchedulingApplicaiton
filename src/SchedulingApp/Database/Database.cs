using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace SchedulingApplicationDemo
{
    public static class Database
    {
        # Maybe refactor to be a labmda? 
        // public static read only string ConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString
        // need to create a function to act as a delegate representing a method to to return a value of the type
        // the type will be MySqlConnection
            
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            return new MySqlConnection(connectionString);
        }
    }
}
