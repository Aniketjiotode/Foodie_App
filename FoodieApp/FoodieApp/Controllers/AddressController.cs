using BusinessLayer.Interface;
using CommanLayer;
using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressBL addressBL;

        public AddressController(IAddressBL addressBL)
        {
            this.addressBL = addressBL;
        }

        // GET: User
        public ActionResult GetallAddress()
        {
            var users = addressBL.GetAlladdress();
            return View(users);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(AddressModel _address)
        {
            try
            {
            if (ModelState.IsValid)
            {
                bool result = addressBL.InsertAddress(_address);
                if (result)
                {
                    return RedirectToAction("GetallAddress");
                }
            }
            return View(_address);

            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public ActionResult Edit(int id)
        {
            var users = addressBL.GetAlladdress();
            return View(users.Find(Emp => Emp.AddressId == id));

        }

        // POST: User/Edit/5
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(AddressModel _address)
        {
            if (ModelState.IsValid)
            {
                bool result = addressBL.UpdateAddress(_address);
                if (result)
                {
                    return RedirectToAction("GetallAddress");
                }
            }
            return View(_address);
        }
        
       

        [HttpPost,ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            bool result = addressBL.DeleteUser(id);
            if (result)
            {
                return RedirectToAction("GetallAddress");
            }
            else
            {
                return View();
            }
        }
    }
}
