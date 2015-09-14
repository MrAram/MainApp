using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using XMLDatabase.XMLDatabase;

namespace MainApplication.DataAccess
{
    public static class DataProvider
    {
        public static string Databasepath { get; set; }

        public static bool AddComment(string comment)
        {
            var dataset = Data.GetData();

            var newRow = dataset.Tables["Comments"].NewRow();
            newRow["Content"] = comment;
            dataset.Tables["Comments"].Rows.Add(newRow);

            Data.Save();

            return true;
        }

        public static List<string> GetComments()
        {
            var dataset = Data.GetData();
            var table = dataset.Tables["Comments"];

            var query = table.AsEnumerable().Select(tb => tb.Field<string>("Content"));
            return query.ToList();
        } 
    }
}