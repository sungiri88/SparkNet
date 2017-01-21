using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Newtonsoft.Json;
using SparkNet.Models;

namespace SparkNet
{
    public class DBManager
    {
        public List<Menu> GetMenu()
        {
            var list = new List<Menu>();
            string commandText = string.Format("SELECT * FROM SiteMenu");
            var dr = MySqlHelper.ExecuteReader(MySqlHelper.ConnectionStringManager, CommandType.Text,commandText);
            while (dr.Read())
            {
                var menu = new Menu
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = dr["Name"].ToString(),
                    ParentID = dr["ParentID"] != DBNull.Value ? Convert.ToInt32(dr["ParentID"]) : (int?)null,
                    Url= dr["Url"].ToString()
                };
                list.Add(menu);
            }
            return list;
        }
    }
}