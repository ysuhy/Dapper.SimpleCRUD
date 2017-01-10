using System;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;

namespace Dapper.SimpleCRUD.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Dapper.SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);

            using (IDbConnection conn = new MySqlConnection(Config.ConnectionString))
            {
                ItemInfo info = new ItemInfo();
                info.Code = "HeYang";
                info.Name = "Ocean";
                info.Icon = "Nothing";
                info.Description = "This is a dapper project";
                info.Type = 1;
                info.Category = 2;
                info.Order = 3;
                info.AddDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                var isInsert = conn.InsertWithoutIdentity(info);
            }



        }
    }
}