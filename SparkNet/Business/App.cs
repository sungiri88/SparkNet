using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SparkNet.Models;


namespace SparkNet.Business
{
    public class App
    {
        public List<Menu> GetMenu()
        {
            List<Menu> lstMenu = (new DBManager()).GetMenu();
            var response = GetMenuTree(lstMenu, null);
            return response;
        }
        public List<Menu> GetMenuTree(List<Menu> list, int? parent)
        {
            return list.Where(x => x.ParentID == parent).Select(x => new Menu
            {
                ID = x.ID,
                Name = x.Name,
                ParentID = x.ParentID,
                Url = x.Url,
                List = GetMenuTree(list, x.ID)
            }).ToList();
        }
    }
}