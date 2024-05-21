using Company.Modules.MenuModul.Models;
using Company.Modules.MenuModul.Components;
using System;
using System.Net.Http;
using System.Web.Http;
using DotNetNuke.Common.Utilities;
using System.Net;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Web.Api;
using System.Collections.Generic;

namespace Company.Modules.MenuModul.Controllers.Api
{
    public class MenusController : DnnApiController
    {
        [HttpGet()]
        public HttpResponseMessage GetMenus()
        {
            try
            {
                //API TEST
                //string dnnHello = "Hello from Dnn!";
                var items = MenuCategoryManager.Instance.GetItems();
                return Request.CreateResponse(HttpStatusCode.OK, items);
            }
            catch (System.Exception ex)
            {
                //Log exception and reply with Error
                Exceptions.LogException(ex);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet()]
        public HttpResponseMessage GetMenusById()
        {
            try
            {
                //API TEST
                //string dnnHello = "Hello from Dnn!";
                var items = MenuCategoryManager.Instance.GetItemById(6);
                return Request.CreateResponse(HttpStatusCode.OK, items);
            }
            catch (System.Exception ex)
            {
                //Log exception and reply with Error
                Exceptions.LogException(ex);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPut]
        [AllowAnonymous]
        public IHttpActionResult UpdateMenu(int menuProductsID,MenuCategory updatedMenuCategory)
        {

                // Save the changes
                MenuCategoryManager.Instance.UpdateItem(menuProductsID, updatedMenuCategory);

                return Ok(); // Return HTTP 200 OK if the update is successful
        }
    }
}