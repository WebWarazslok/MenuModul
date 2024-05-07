using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;
using Hotcakes.CommerceDTO.v1.Catalog;
using System;
using System.Web.Caching;

namespace Company.Modules.MenuModul.Models
{
    [TableName("MenuModul_MenuProducts")]
    //setup the primary key for table
    [PrimaryKey("MenuProductsID")]
    //configure caching using PetaPoco
    [Cacheable("MenuProductsCache", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class MenuCategory
    {
        public int MenuProductsID { get; set; }
        public int OptionsID { get; set; }
        public string Category { get; set; }
        public string Day { get; set; }
        public int SKU { get; set; }
    }
}