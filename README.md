# Dapper.SimpleCRUD
My first open source project.

Add method InsertWithoutIdentity. 
This method can add row into database without identity.

      ItemInfo info = new ItemInfo();
      info.Code = "HeYang";
      info.Name = "Ocean";
      info.Icon = "Nothing";
      info.Description = "This is a dapper project";
      info.Type = 1;
      info.Category = 2;
      info.Order = 3;
      info.AddDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

      using (IDbConnection conn = new MySqlConnection(Config.ConnectionString))
      {                
          var isInsert = conn.InsertWithoutIdentity(info);
      }
 
The entity without identity id.
 
    [Table("zb_item")]
    public class ItemInfo
    {
        [Key]
        public string Code { get; set; }

        public string Name { get; set; }
        public int Category { get; set; }
        public int Type { get; set; }

        public string Icon { get; set; }
        public int Order { get; set; }

        public string Description { get; set; }
        public int AddDate { get; set; } 

    }
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
