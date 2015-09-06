using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using XMLDatabase.XMLDatabase;

namespace MainApplication.DataAccess
{
    public static class DataProvider
    {
        public static string Databasepath { get; set; }

        public static bool AddComment(string comment)
        {
            //string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Database.accdb");
            //using (OleDbConnection connection = new OleDbConnection(connString))
            //{
            //    connection.Open();
            //    OleDbCommand command = new OleDbCommand(string.Format("INSERT INTO Comments (ID, Comment) VALUES ({0});", comment), connection);
            //    command.ExecuteNonQuery();
            //    //command.Parameters.AddWithValue("@1", userName)

            //}

            return true;
        }

        public static List<string> GetComments()
        {
            var list = new List<string>();
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Database.accdb");
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * from  Comments", connection);
                //command.Parameters.AddWithValue("@1", userName)
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader[1].ToString());
                }
            }
           
            return list;
        } 
    }
}