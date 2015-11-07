using System.Data;

namespace MainApplication.DataAccess 
{
    public partial class Data 
    {
        public void Load()
        {
            try
            {
                ReadXml(System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Database.xml"),
                        XmlReadMode.IgnoreSchema);
            }
            catch
            {
            }

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
