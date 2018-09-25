using EntityModellibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MySampleApi.Controllers
{
    public class HomeController : Controller
    {
        static HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        //public ActionResult Test1()
        //{
        //    ViewBag.Title = "Home Page";
        //    IEnumerable<ProductsQuery> students = null;

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://localhost:40080/api/");
        //        //HTTP GET
        //        var responseTask = client.GetAsync("Product");
        //        responseTask.Wait();

        //        var result = responseTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readTask = result.Content.ReadAsAsync<IList<ProductsQuery>>();
        //            readTask.Wait();

        //            students = readTask.Result;
        //        }
        //        else //web api sent error response 
        //        {
        //            //log response status here..

        //            students = Enumerable.Empty<ProductsQuery>();

        //            ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
        //        }
        //    }
        //    return View(students);

        //}


        public ActionResult DefaultAddResult()
        {
            ViewBag.Title = "Sum Result";
            int Outresult = 0;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5397/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Calculator/get?id=3&id1=4");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<int>();
                    readTask.Wait();

                    Outresult = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    Outresult = 0;//Enumerable.Empty<ProductsQuery>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
                ViewBag.Outresultmy = Outresult;
            }
            return View(Outresult);
        }

        public ActionResult Products(int recordid)
        {
            ViewBag.Title = "Products Result";
            ProductEntity Outresult ;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5397/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Product/get?id="+ recordid + "");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ProductEntity>();
                    readTask.Wait();

                    Outresult = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    Outresult = null;//Enumerable.Empty<ProductsQuery>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
                ViewBag.Outresultmy = Outresult;
            }
            return View(Outresult);
        }

    }
}
