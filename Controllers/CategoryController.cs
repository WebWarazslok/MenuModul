﻿using Company.Modules.MenuModul.Components;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Company.Modules.MenuModul.Models;

namespace Company.Modules.MenuModul.Controllers
{
    public class CategoryController : DnnController
    {
        #region API
        /*public const string ApiKey = "1-2d78ad9c-d5ca-46e7-8cbc-066d8e72b40c";
        public const string ApiUrl = "http://20.234.113.211:8106";
        public const string ApiPath = "/DesktopModules/Hotcakes/API/rest/v1/";
        public const string EndPoint = "categories";
        public async Task<ActionResult> Index()
        {
            // GET kérés az API-hoz
            string response = await GetInfoEndPointAsync(ApiUrl, ApiKey, ApiPath, EndPoint);

            // JSON válasz feldolgozása és az eredmény kinyerése
            JObject jsonResponse = JObject.Parse(response);

            // Kiválasztjuk a MetaTitle és Name tulajdonságokat, majd szűrjük azokat, ahol a Name tartalmazza a "csomagok" kifejezést
            var selectedData = jsonResponse["Content"]
                .Select(c => new { MetaTitle = c["MetaTitle"].ToString(), Name = c["Name"].ToString() })
                .Where(c => c.Name.Contains("csomagok"))
                .ToList();

            IEnumerable<Category> categories = selectedData.Select(item => new Category
            {
                Name = item.Name,
                MetaTitle = item.MetaTitle
            });

            // Visszaadjuk a nézetet, és átadjuk neki a kiválasztott adatokat
            return View(categories);
        }

        private async Task<string> GetInfoEndPointAsync(string apiUrl, string apiKey, string apiPath, string endPoint)
        {
            string endpointUrl = $"{apiUrl}{apiPath}{endPoint}?key={apiKey}";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Api-Key", apiKey);

                try
                {
                    var response = await client.GetAsync(endpointUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return $"Hiba a termékek lekérdezésekor: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    // Logoljuk a kivételt
                    Console.WriteLine($"Hiba történt a kérés során: {ex.Message}");
                    return $"Hiba történt a kérés során: {ex.Message}";
                }
            }
        }*/
        #endregion

        #region IfAPIIsNotWorking
        static IList<Category> categories = new List<Category>{
                new Category() {Name = "Ázsiai" } ,
                new Category() {Name = "Európai" } ,
                new Category() {Name = "Dél-Amerikai" } ,
                new Category() {Name = "Vegyes" } ,
            };
        // GET: Student
        public ActionResult Index()
        {
            return View(categories);
        }
        #endregion
    }
}