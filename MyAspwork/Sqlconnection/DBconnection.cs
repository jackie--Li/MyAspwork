using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration; 
namespace MyAspwork.Sqlconnection
{
   public class DBconnection
  {
       public static MySqlConnection myConnection;
       
        public static MySqlConnection getconn()
        {
            myConnection = new MySqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString());  
            return myConnection;
        }
       //fsafsafsfsfdsfsf

      //string query = "select * from guestbook";
      //MySqlConnection myConnection = new MySqlConnection("server=localhost;user id=root;password=;database=guestbook"); 
      //MySqlCommand myCommand=new MySqlCommand(query,myConnection);
      //myConnection.Open();
      //myCommand.ExecuteNonQuery();
      //MySqlDataReader myDataReader = myCommand.ExecuteReader();
      //string bookres="";
      //while (myDataReader.Read()==true)
      //{
      //    bookres+=myDataReader["id"];
      //    bookres+=myDataReader["user"];
      //    bookres += myDataReader["pass"];
      //}
      //myDataReader.Close();
      //myConnection.Close();
      //lb1.Text = bookres;      


        
  }
}