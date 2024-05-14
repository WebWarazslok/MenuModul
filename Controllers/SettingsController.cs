/*
' Copyright (c) 2024 WebWarazslok
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using Company.Modules.MenuModul.Components;
using DotNetNuke.Collections;
using DotNetNuke.Security;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Company.Modules.MenuModul.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
    [DnnHandleError]
    public class SettingsController : DnnController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Settings()
        {
            var catForDropDown =  MenuCategoryManager.Instance.GetItems();

            var i = 0;
            List<SelectListItem> items = new List<SelectListItem>();

            foreach (var item in catForDropDown)
            {
                items.Add(new SelectListItem { Text = item.Category, Value = i.ToString() });
                i++;
            }

            ViewBag.MovieType = items;
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="supportsTokens"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        [DotNetNuke.Web.Mvc.Framework.ActionFilters.ValidateAntiForgeryToken]
        public ActionResult Settings(Models.Settings settings)
        {
            ModuleContext.Configuration.ModuleSettings["MenuModul_CategoryId"] = settings.CategoryId.ToString();
            ModuleContext.Configuration.ModuleSettings["MenuModul_ProductId"] = settings.ProductId.ToString();

            return RedirectToDefaultRoute();
        }
    }
}