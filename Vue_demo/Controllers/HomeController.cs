using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vue_demo.Models.bll;

namespace Vue_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public string MealGetData()
        {
            Order_bll _ob = new Order_bll();
            return _ob.get_OrderData();
        }

        public bool setMealData(string orderNum) 
        {
            bool _req = false;
            //到bll修改狀態並存入DB
            _req = true;
            return _req;
        }
    }
}