using System.Data;

namespace MainApplication.DataAccess 
{
    public partial class Data 
    {
        public Data(bool withSchema)
        {
            ReadXml(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Database.xml"), XmlReadMode.IgnoreSchema);
        }
        public void SaveChanges()
        {
            if (HasChanges())
            {
                WriteXml(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Database.xml"));
                AcceptChanges();
            }
        }
    }
}
