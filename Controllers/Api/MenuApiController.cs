using Company.Modules.MenuModul.Components;
using System;

namespace Company.Modules.MenuModul.Controllers
{
    public class MenuApiController : Api.RestApiController
    {
        public ICategoryManager CategoryManager { get; }
        public MenuApiController() { }
        public MenuApiController(ICategoryManager categoryManager)
        {
            CategoryManager = categoryManager
                ?? throw new ArgumentNullException(nameof(categoryManager));
        }
    }
}