using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommanLayer
{
    public class RestaurantModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int CuisineId { get; set; }
        public int Rating { get; set; }
        public int TypeId { get; set; }
        public int CategoryId { get; set; }
        public string Menutype { get; set; }
        public int CostPerPerson { get; set; }
        public string Image { get; set; }


    }
}
