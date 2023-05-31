using CommanLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IRestaurantRL
    {
        public List<RestaurantModel> GetAllRestaurant(int id , string city);
        public List<CityModel> GetCity(string prefix);
        public List<RestaurantModel> GetRestaurantbyName(string restuarant, string city);
        public List<MenuModel> GetMenu(string restaurant);




    }
}
