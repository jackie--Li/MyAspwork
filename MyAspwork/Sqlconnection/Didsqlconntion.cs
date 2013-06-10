using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MyAspwork.Model;

namespace MyAspwork.Sqlconnection
{
    public class Didsqlconntion
    {
        //public static MySqlConnection conn;
        public static MySqlConnection conn = DBconnection.getconn();
        PersonEntity personentity = new PersonEntity();
        public bool getperson(PersonEntity person) 
        {
           
            bool flag = false;
            conn.Open();
            string query = "select * from persondetails where username=?name and password=?password";
            MySqlCommand myCommand = new MySqlCommand(query, conn);
            myCommand.Parameters.AddWithValue("?name", person.Username);
            myCommand.Parameters.AddWithValue("?password", person.Password);
          
            myCommand.ExecuteNonQuery();
            MySqlDataReader myDataReader = myCommand.ExecuteReader();
            while (myDataReader.Read() == true)
            {
                personentity.Username = myDataReader["username"].ToString().Trim();
                personentity.Password = myDataReader["password"].ToString().Trim();
            }
            if (person.Username.Equals(personentity.Username)&&person.Password.Equals(personentity.Password))
            {
                flag =true ;
            }
            conn.Close();
            myDataReader.Close();
            return flag;
       }
    }
}