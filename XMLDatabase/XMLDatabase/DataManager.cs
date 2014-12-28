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
        private static DataSet _dataSet = new Database();
        public static string XMLDataPath { get; set; }

        public static bool CleanDatabase()
        {
            try
            {
                _dataSet = new DataSet();
                var doc = new XmlDocument();
                doc.LoadXml(string.Format("<Database xmlns=\"{0}\"></Database>", "http://tempuri.org/Database.xsd"));
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
                _dataSet.ReadXml(XMLDataPath);
                return _dataSet;
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
                var xml = _dataSet.GetXml();
                var doc = new XmlDocument();
                doc.LoadXml(xml);
                CleanDatabase();
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