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
        Category GetCategory(int catId);
    }
    internal class CategoryManager : ServiceLocator<ICategoryManager, CategoryManager>, ICategoryManager
    {
        public Category GetCategory(int catId)
        {
            Category t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Category>();
                t = rep.GetById(catId);
            }
            return t;
        }

        protected override System.Func<ICategoryManager> GetFactory()
        {
            return () => new CategoryManager();
        }
    }
}
