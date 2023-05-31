using CommanLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IuserBL
    {
        public bool InsertUser(UserModel user);
        public List<UserModel> GetAllUsers();
        public bool UpdateUser(UserModel user);
        public bool DeleteUser(int userId);
        public List<CategoryModel> GetAllCategory();
        public UserModel Login(LoginModel login);

    }
}
