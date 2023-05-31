using BusinessLayer.Interface;
using CommanLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
     public class RestaurantBL:IRestaurantBL
    {
        private readonly IRestaurantRL irestaurantRL;

        public RestaurantBL(IRestaurantRL irestaurantRL)
        {
            this.irestaurantRL = irestaurantRL;
        }   


        public List<RestaurantModel> Getallrestaurant(int id, string city)
        {
            try
            {
               return  irestaurantRL.GetAllRestaurant(id,city);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CityModel> GetCity(string prefix)
        {
            try
            {
                return irestaurantRL.GetCity(prefix);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<RestaurantModel> GetRestaurantbyName(string restuarant, string city)
        {
            try
            {
                return irestaurantRL.GetRestaurantbyName(restuarant,city);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<MenuModel> GetMenu(string restaurant)
        {
            try
            {
                return irestaurantRL.GetMenu(restaurant);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
