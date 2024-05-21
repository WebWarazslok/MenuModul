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
    public interface ICategoryManager
    {
        IEnumerable<MenuCategory> GetItems();
        MenuCategory GetItemById(int menuProductsId);
        void UpdateItem(int menuProductsID,MenuCategory menuCategory);
    }
    public class MenuCategoryManager : ServiceLocator<ICategoryManager, MenuCategoryManager>, ICategoryManager
    {
        public IEnumerable<MenuCategory> GetItems()
        {
            IEnumerable<MenuCategory> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<MenuCategory>();
                t = rep.Get();
            }
            return t;
        }
        public MenuCategory GetItemById(int menuProductsId)
        {
            MenuCategory t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<MenuCategory>();
                t = rep.GetById(menuProductsId);
            }
            return t;
        }

        public void UpdateItem(int menuProductsID,MenuCategory menuCategory)
        {
                using (var context = DataContext.Instance())
                {
                    var repository = context.GetRepository<MenuCategory>();
                    var existingMenuCategory = repository.GetById(menuProductsID);

                    if (existingMenuCategory != null)
                    {
                        existingMenuCategory.Category = menuCategory.Category;
                        existingMenuCategory.Day = menuCategory.Day;
                        existingMenuCategory.OptionsID = menuCategory.OptionsID;
                        existingMenuCategory.Price = menuCategory.Price;
                        existingMenuCategory.ProductName = menuCategory.ProductName;
                        existingMenuCategory.Quantity = menuCategory.Quantity;
                        existingMenuCategory.SKU = menuCategory.SKU;

                        repository.Update(existingMenuCategory);
                    }
                }
        }
        protected override System.Func<ICategoryManager> GetFactory()
        {
            return () => new MenuCategoryManager();
        }
    }
}
