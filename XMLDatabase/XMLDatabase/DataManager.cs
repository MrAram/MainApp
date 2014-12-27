using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Reflection;
using System.Xml;

namespace XMLDatabase.XMLDatabase
{
    public static class Data
    {
        private static readonly DataSet DataSet = new Database();
        public static string XMLDataPath { get; set; }

        public static bool CleanDatabase()
        {
            try
            {
                var doc = new XmlDocument();
                doc.LoadXml("");
                doc.Save(XMLDataPath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataSet GetData()
        {
            try
            {
                DataSet.ReadXml(XMLDataPath);
                return DataSet;
            }
            catch
            {
                return new Database();
            }          
        }

        public static bool Save()
        {
            try
            {
                var xml = DataSet.GetXml();
                var doc = new XmlDocument();
                doc.LoadXml(xml);
                doc.Save(XMLDataPath);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}