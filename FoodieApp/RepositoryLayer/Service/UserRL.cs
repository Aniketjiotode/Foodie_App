using CommanLayer;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.Service
{
    public class UserRL:IuserRL
    {
        //private SqlConnection con;
        private readonly IConfiguration configuration;
        SqlConnection connection;
        public UserRL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

   
        public bool InsertUser(UserModel user)
        {
            using ( connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_CreateUser", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@EmailId", user.EmailId);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@MobileNo", user.MobileNo);

                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public List<UserModel> GetAllUsers()
        {
            List<UserModel> users = new List<UserModel>();

            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_GetAllUsers", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    UserModel user = new UserModel();
                    user.UserId = Convert.ToInt32(reader["UserId"]);
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.EmailId = reader["EmailId"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.MobileNo = Convert.ToInt64(reader["MobileNo"]);
                    user.ResetPasswordCode = reader["ResetPasswordCode"].ToString();
                    users.Add(user);
                }
            }
            return users;
        }


        public bool UpdateUser(UserModel user)
        {
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_UpdateUsers", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("UserId", user.UserId);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@EmailId", user.EmailId);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@MobileNo", user.MobileNo);
                command.Parameters.AddWithValue("@ResetPasswordCode", user.ResetPasswordCode);

                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

         

        public bool DeleteUser(int userId)
        {
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_DeleteUser", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public List<CategoryModel> GetAllCategory()
        {
            List<CategoryModel> categories = new List<CategoryModel>();

            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_ReadAllCategory", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CategoryModel category = new CategoryModel();
                    category.CategoryId = reader.GetInt32(0);
                    category.CategoryName = reader.GetString(1);
                    category.CategoryImage = reader.GetString(2);
                    category.CategoryDescription = reader.GetString(3);

                    categories.Add(category);
                }
            }
            return categories;
        }

        public UserModel Login(LoginModel login)
        {
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_GetAllUsers", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {                  
                   var  EmailId = reader["EmailId"].ToString();
                   var  Password = reader["Password"].ToString();

                    if (login.EmailId.Equals(EmailId) && login.Password.Equals(Password))
                    {
                        UserModel user = new UserModel();
                        user.UserId = Convert.ToInt32(reader["UserId"]);
                        user.FirstName = reader["FirstName"].ToString();
                        user.LastName = reader["LastName"].ToString();
                        user.EmailId = reader["EmailId"].ToString();
                        user.Password = reader["Password"].ToString();
                        user.MobileNo = Convert.ToInt64(reader["MobileNo"]);
                        return user;
                    }              
                }
            }
            return null;
        } 

       
    }
}
