using BusinessLayer.Interface;
using CommanLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FoodApp.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: RestaurantController

        private readonly IRestaurantBL irestaurantBL;
        private readonly IuserBL iuserBL;
        public string name;

       public RestaurantController(IRestaurantBL irestaurantBL, IuserBL iuserBL)
        {
            this.irestaurantBL = irestaurantBL;
            this.iuserBL = iuserBL; 
        }

        [HttpPost]
        public ActionResult City(string cityname) 
        {
            try
            {
            TempData["city"]= cityname;
            HttpContext.Session.SetString("city",cityname);
            //name = cityname;
            return new JsonResult(true);

            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        
        }

        public ActionResult Listing(int id)
        {
            try
            {
                var userid = HttpContext.Session.GetInt32("UserId");
                if (userid != null)
                {
                    string name = HttpContext.Session.GetString("city");
                    TempData["city"] = HttpContext.Session.GetString("city");
                    //string cityname = name;
                    if (name != null)
                    {
                        List<RestaurantModel> rest = irestaurantBL.Getallrestaurant(id, name);
                        ViewData["list"] = rest;
                        return View("ListingPage");
                    }
                    else
                    {
                        TempData["error"] = "please select City to move forward";
                        List<CategoryModel> user = iuserBL.GetAllCategory();
                        ViewData["category"] = user;
                        var citylist = irestaurantBL.GetCity("");
                        List<string> list = new List<string>();
                        foreach (var city in citylist)
                        {
                            list.Add(city.CityName);
                        }
                        ViewBag.citylist = list;
                        return View("User","HomePage");
                    }
                }
                else
                {
                    ViewBag.loginmsg = "Please login to move forward";
                    List<CategoryModel> user = iuserBL.GetAllCategory();
                    ViewData["category"] = user;
                    var citylist = irestaurantBL.GetCity("");
                    List<string> list = new List<string>();
                    foreach (var city in citylist)
                    {
                        list.Add(city.CityName);
                    }
                    ViewBag.citylist = list;
                    return RedirectToAction("HomePage","User");
                }
            }
            catch (System.Exception  ex)
            {

                throw ex;
            }
        }
        [HttpGet]
        public ActionResult Showallrestaurant()
        {
            try
            {
            string name = HttpContext.Session.GetString("city");
            int id =0;
            TempData["city"]=name;
            //string cityname = name;
            List<RestaurantModel> rest = irestaurantBL.Getallrestaurant(id, name);
          
            ViewData["list"] = rest;
            return View("ListingPage");

            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]

        public ActionResult Getallcity(string prefix)
        {
            try
            {
            var cityname = irestaurantBL.GetCity(prefix);
            return  Json(cityname);

            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        //public ActionResult GetRestautrant()
        //{
        //   return View("ListingPage");       
        //}

        [HttpPost]
        public ActionResult GetRestautrantbyName()
        {
            try
            {
                var userid = HttpContext.Session.GetInt32("UserId");
                if (userid != null)
                {
                    string city = HttpContext.Request.Form["cityName"].ToString();
                    string name = HttpContext.Request.Form["RestName"].ToString();
                    if (city != "")
                    {
                        HttpContext.Session.SetString("city", city);
                        TempData["city"] = HttpContext.Session.GetString("city");
                        List<RestaurantModel> rest = irestaurantBL.GetRestaurantbyName(name, city);
                        ViewData["list"] = rest;
                        return View("ListingPage");
                    }
                    else
                    {
                        var City = HttpContext.Session.GetString("city");
                        string Name = HttpContext.Request.Form["searchinput"].ToString();
                        TempData["city"] = HttpContext.Session.GetString("city");
                        List<RestaurantModel> rest = irestaurantBL.GetRestaurantbyName(Name, City);
                        ViewData["list"] = rest;
                        return View("ListingPage");
                    }
                }else
                {
                    ViewBag.loginmsg = "Please login to move forward";
                    List<CategoryModel> user = iuserBL.GetAllCategory();
                    ViewData["category"] = user;
                    var citylist = irestaurantBL.GetCity("");
                    List<string> list = new List<string>();
                    foreach (var city in citylist)
                    {
                        list.Add(city.CityName);
                    }
                    ViewBag.citylist = list;
                    return View("HomePage");
                }

            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }


        public ActionResult MenuPage()
        {
            return View("MenuPage");
        }

        public ActionResult LoginHomePage()
        {
            try
            {
                List<CategoryModel> user = iuserBL.GetAllCategory();
                ViewData["category"] = user;

                var userid = HttpContext.Session.GetInt32("UserId");
                var users = iuserBL.GetAllUsers().Find(a => a.UserId == userid);
                ViewBag.Name = users.FirstName;
                var citylist = irestaurantBL.GetCity("");
                List<string> list = new List<string>();
                foreach (var city in citylist)
                {
                    list.Add(city.CityName);
                }
                ViewBag.citylist = list;

                return View("LoginHomePage");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = iuserBL.Login(login);
                    if (result != null)
                    {
                        HttpContext.Session.SetInt32("UserId", result.UserId);
                        HttpContext.Session.SetString("EmailId", result.EmailId);
                        return RedirectToAction("LoginHomePage");
                    }
                    else
                    {
                        TempData["loginfail"] = "Try again with correct Emailid and password";

                        return RedirectToAction("HomePage");
                    }
                }
                return View(login);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
        public ActionResult  MenuList(string id) 
        {
            try
            {
                var City = HttpContext.Session.GetString("city");
                var restaurant = irestaurantBL.GetRestaurantbyName(id,City).Find(a=> a.Name.Contains(id));
                ViewBag.Restaurant=restaurant;
                var menulist=irestaurantBL.GetMenu(id);
                ViewBag.Menu=menulist;
                return View("MenuPage");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
