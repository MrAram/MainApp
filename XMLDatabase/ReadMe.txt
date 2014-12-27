1.Create .xml file and insert in application(example.   Database.xml)
2.Set XMLDataPath (your Database.xml file path) (example. in asp.net   Data.XMLDataPath = HttpContext.Current.Server.MapPath("~/App_Data/Database.xml");)
3.Create in Database.xsd your tables relations...
3. Use functions (example )
Data.XMLDataPath = HttpContext.Current.Server.MapPath("~/App_Data/Database.xml");
            var dataset = Data.GetData();
            

            //var newRow = dataset.Tables["Table"].NewRow();
            //newRow["Column"] = "AS";
            //dataset.Tables["Table"].Rows.Add(newRow);

            //Data.Save();

            var table = dataset.Tables["Table"];

            var query = table.AsEnumerable().
    Select(tb => new
    {
        Name = tb.Field<string>("Column"),
    });

            var res = query.ToList();


