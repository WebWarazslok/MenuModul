using Company.Modules.MenuModul.Models;
using DotNetNuke.Data;
using DotNetNuke.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Modules.MenuModul.Components
{
    internal interface ICategoryManager
    {
        IEnumerable<MenuCategory> GetCategory();
    }
    internal class MenuCategoryManager : ServiceLocator<ICategoryManager, MenuCategoryManager>, ICategoryManager
    {
        public IEnumerable<MenuCategory> GetCategory()
        {
            var csom = "%csomagok%";
            IEnumerable<MenuCategory> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<MenuCategory>();
                t = rep.Find("WHERE NAME LIKE @0",csom);
            }
            return t;
        }

        protected override System.Func<ICategoryManager> GetFactory()
        {
            return () => new MenuCategoryManager();
        }
    }
}
