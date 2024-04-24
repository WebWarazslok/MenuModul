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
        MenuCategory GetCategory(int catId);
    }
    internal class MenuCategoryManager : ServiceLocator<ICategoryManager, MenuCategoryManager>, ICategoryManager
    {
        public MenuCategory GetCategory(int catId)
        {
            MenuCategory t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<MenuCategory>();
                t = rep.GetById(catId);
            }
            return t;
        }

        protected override System.Func<ICategoryManager> GetFactory()
        {
            return () => new MenuCategoryManager();
        }
    }
}
