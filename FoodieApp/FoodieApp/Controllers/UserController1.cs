using BusinessLayer.Interface;
using CommanLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using MyntraApp.Models;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodApp.Controllers
{
    //[Route("[controller]/[action]/{id?}")]
    public class UserController : Controller
    {
        private readonly IuserBL _userBL;
        private readonly IRestaurantBL irestaurantBL;

        public UserController(IuserBL userBL, IRestaurantBL irestaurantBL)
        {
            _userBL = userBL;
            this.irestaurantBL = irestaurantBL; 
        }

        // GET: User
        public ActionResult Getalluser()
        {
            try
            {
            var users = _userBL.GetAllUsers(); 
            return View(users);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }  
      
        
        
        public ActionResult HomePage()
        {
            try
            {
            List<CategoryModel> user = _userBL.GetAllCategory();
            ViewData["category"] = user;
                var citylist = irestaurantBL.GetCity("");
                List<string> list = new List<string>();
                foreach (var city in citylist)
                {
                    list.Add(city.CityName);
                }
                ViewBag.citylist = list;
            return View();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public ActionResult LoginHomePage()
        {
            try
            {
            List<CategoryModel> user = _userBL.GetAllCategory();
            ViewData["category"] = user;

            var userid = HttpContext.Session.GetInt32("UserId");
            var users = _userBL.GetAllUsers().Find(a => a.UserId == userid);
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
        public ActionResult LoginPage()
        {     
            return View();
        }


        //get: user/create
        public ActionResult Adduser()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        //public ActionResult SignupPage(UserModel user)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        bool result = _userBL.InsertUser(user);
        //        if (result)
        //        {
        //            ViewBag.Confirm = "SignUp Successfully";
        //            return RedirectToAction("SignupPage");
        //        }
        //    }
        //    return View(user);
        //} 
        public ActionResult SignupPage(UserModel user)
        {
            try
            {
            if (ModelState.IsValid)
            {

                bool result = _userBL.InsertUser(user);
                if (result)
                {
                    ViewBag.Confirm = "SignUp Successfully";
                        var citylist = irestaurantBL.GetCity("");
                        List<string> list = new List<string>();
                        foreach (var city in citylist)
                        {
                            list.Add(city.CityName);
                        }
                        ViewBag.citylist = list;
                        return RedirectToAction("HomePage");
                }
            }
            return View(user);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
            var users = _userBL.GetAllUsers();
            return View(users. Find(Emp =>  Emp.UserId == id));
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        // POST: User/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(UserModel user)
        {
            try
            {
            if (ModelState.IsValid)
            {
                bool result = _userBL.UpdateUser(user);
                if (result)
                {
                    return RedirectToAction("Getalluser");
                }
            }
            return View(user);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public ActionResult Delete(int id)
        {
            bool result = _userBL.DeleteUser(id);
            if (result)
            {
                return RedirectToAction("Getalluser");
            }
            else
            {
                return View();
            }
        }

        //public ActionResult Login()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            try
            {
            if(ModelState.IsValid)
            {
                var result = _userBL.Login(login);
                if (result != null)
                {
                    HttpContext.Session.SetInt32("UserId", result.UserId);
                    HttpContext.Session.SetString("EmailId", result.EmailId);
                    return RedirectToAction("LoginHomePage");
                }
                else{
                        TempData["loginfail"] = "Try again with correct Emailid and password";

                       return  RedirectToAction("HomePage");
                    }
            }
            return View(login);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult Logout()
        {
            try
            {
           HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserId");
            return RedirectToAction("HomePage");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }


        [HttpPost]

        public ActionResult ForgotPassword(string EmailId)
        {
            try
            {
            var user = _userBL.GetAllUsers();
            var result=user.Find(a=>a.EmailId == EmailId);
            if(result!= null)
            {
                var resetCode = Guid.NewGuid().ToString();
                MsmqModel msmq = new MsmqModel();
                msmq.sendDatatoQueue(resetCode);
                result.ResetPasswordCode = resetCode;
                _userBL.UpdateUser(result);
                ViewBag.Message= "Reset Password link Sent to your Emailaddress please Check Email to Reset Password";
            }
            else
            {
                ViewBag.Message = "Account not Found";
            }
            return View();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public ActionResult ResetPassword(string id)
        {
            try
            {
            if (ModelState.IsValid)
            {
                var user = _userBL.GetAllUsers();
                var result = user.Find(a => a.ResetPasswordCode == id);
                if (result!= null)
                {
                    ResetPasswordModel model = new ResetPasswordModel();
                    model.ResetCode= id;    
                    return View(model);
                }
                else
                {
                    return  View();
                }

            }
            return View();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]

        public ActionResult ResetPassword(ResetPasswordModel model)
        {
            try
            {
            if(ModelState.IsValid)
            { 
                var user= _userBL.GetAllUsers();
                var result = user.Find(a => a.ResetPasswordCode == model.ResetCode);
                if (result!= null)
                {
                    if (model.Password.Equals(model.ConfirmPassword))
                    {
                        result.Password = model.Password;
                        _userBL.UpdateUser(result);
                        ViewBag.Message = "New password updated successfully";
                    }
                    else
                    {
                       ViewBag.Message = "Password and ConfirmPassword not match";
                    }
                    
                }
            }
            else
            {
                ViewBag.Message = "something invalid";
            }
            return View(model);

            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }

    }
}
