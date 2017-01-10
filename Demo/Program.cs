using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);


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

        }
    }
}
