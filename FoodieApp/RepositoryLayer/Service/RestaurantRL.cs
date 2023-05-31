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
    public class RestaurantRL:IRestaurantRL
    {
        private readonly IConfiguration configuration;
        SqlConnection connection;
        public RestaurantRL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public List<RestaurantModel> GetAllRestaurant(int id,string city)
        {
            List<RestaurantModel> restaurants = new List<RestaurantModel>();
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("Sp_Getallrestaurants", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@categoryid", id);
                command.Parameters.AddWithValue("@cityname", city);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RestaurantModel rest = new RestaurantModel();
                    //rest.Id = Convert.ToInt32(reader["Id"]);
                    rest.Name= Convert.ToString(reader["Name"]);
                    //rest.CityId = Convert.ToInt32(reader["CityId"]);
                    //rest.CategoryId = Convert.ToInt32(reader["Category"]);
                    //rest.CuisineId = Convert.ToInt32(reader["CuisineId"]);
                    //rest.TypeId = Convert.ToInt32(reader["TypeId"]);
                    //rest.Rating = Convert.ToInt32(reader["Rating"]);
                    rest.Menutype = reader["Menutype"].ToString();
                    rest.CostPerPerson = Convert.ToInt32(reader["CostPerPerson"]);
                    rest.Image = reader["Image"].ToString();
                    restaurants.Add(rest);                
                }
            }
            return restaurants;
        }

        public List<CityModel> GetCity(string prefix)
        {
            List<CityModel> cityname= new List<CityModel>();
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("Getcity", connection);
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@prefix",prefix );

                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                while (reader.Read())
                {
                    CityModel city = new CityModel();
                    city.CityId = Convert.ToInt32(reader["cityId"]);
                    city.CityName = Convert.ToString(reader["City"]);
                    cityname.Add(city);
                }
            }
            return cityname;
        }


        public List<RestaurantModel> GetRestaurantbyName(string restuarant, string city)
        {
            List<RestaurantModel> restaurants = new List<RestaurantModel>();
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("GetRestbyname", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", restuarant);
                command.Parameters.AddWithValue("@city", city);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RestaurantModel rest = new RestaurantModel();
                    //rest.Id = Convert.ToInt32(reader["Id"]);
                    rest.Name = Convert.ToString(reader["Name"]);
                    //rest.CityId = Convert.ToInt32(reader["CityId"]);
                    //rest.CategoryId = Convert.ToInt32(reader["Category"]);
                    //rest.CuisineId = Convert.ToInt32(reader["CuisineId"]);
                    //rest.TypeId = Convert.ToInt32(reader["TypeId"]);
                    //rest.Rating = Convert.ToInt32(reader["Rating"]);
                    rest.Menutype = reader["Menutype"].ToString();
                    rest.CostPerPerson = Convert.ToInt32(reader["CostPerPerson"]);
                    rest.Image = reader["Image"].ToString();
                    restaurants.Add(rest);
                }
            }
            return restaurants;
        }

        public List<MenuModel> GetMenu(string restaurant)
        {
            List<MenuModel> menu = new List<MenuModel>();
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_GetAllMenu", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@restaurant", restaurant);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   MenuModel menuModel= new MenuModel();
                    menuModel.Id= Convert.ToInt32(reader["MenuId"]);
                    menuModel.Name= Convert.ToString(reader["MenuName"]);
                    menuModel.RestaurantId = Convert.ToInt32(reader["RestaurantId"]);
                    menuModel.Image= reader["Image"].ToString();
                    menuModel.Rating = reader["Rating"].ToString();
                    menuModel.CuisineId = Convert.ToInt32(reader["CusineId"]);
                    menuModel.Price = Convert.ToInt32(reader["Price"]);
                    menu.Add(menuModel);
                }
            }
            return menu;
        }
    }
}
