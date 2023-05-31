using BusinessLayer.Interface;
using CommanLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class UserBL:IuserBL
    {
		private readonly IuserRL iuserRL;

		public UserBL(IuserRL iuserRL)
		{
			this.iuserRL = iuserRL;
		}
        public bool InsertUser(UserModel user)
        {
			try
			{
				return iuserRL.InsertUser(user);
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public List<UserModel> GetAllUsers()
		{
			try
			{
                return iuserRL.GetAllUsers();
            }
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool UpdateUser(UserModel user)
		{
			try
			{
				return iuserRL.UpdateUser(user);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public bool DeleteUser(int userId) 
		{
			try
			{
				return iuserRL.DeleteUser(userId);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

        public List<CategoryModel> GetAllCategory()
        {
            try
            {
                return iuserRL.GetAllCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserModel Login(LoginModel login)
        {
            try
            {
                return iuserRL.Login(login);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
