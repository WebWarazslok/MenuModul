using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;
using Hotcakes.CommerceDTO.v1.Catalog;
using System;
using System.Web.Caching;

namespace Company.Modules.MenuModul.Models
{
    /*[TableName("hcc_CategoryTranslations")]
    //setup the primary key for table
    [PrimaryKey("CategoryTranslationId", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("CategoryTranslations", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]*/
    public class Category : CategorySnapshotDTO
    {
        public string Name { get; set; }
        //public string MetaTitle { get; set; }
    }
}