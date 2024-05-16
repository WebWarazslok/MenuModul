using Company.Modules.MenuModul.Models;
using Company.Modules.MenuModul.Components;
using System;
using System.Net.Http;
using System.Web.Http;
using DotNetNuke.Common.Utilities;
using System.Net;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Web.Api;

namespace Company.Modules.MenuModul.Controllers.Api
{
    public class MenusController : DnnApiController
    {
        [HttpGet()]
        public HttpResponseMessage Get()
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
        /*
        [DnnAuthorize()]
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public HttpResponseMessage DnnHelloPersonalize(DetailsModel data)
        {
            try
            {
                string dnnMessage = "Hello " + data.name + " from DNN!";
                return Request.CreateResponse(HttpStatusCode.OK, dnnMessage);
            }
            catch (System.Exception ex)
            {
                //Log exception and reply with Error
                Exceptions.LogException(ex);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }*/
    }
}