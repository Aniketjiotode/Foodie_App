using System;
using System.Collections.Generic;
using System.Text;

namespace CommanLayer
{
    public  class MenuModel
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }
        public int CuisineId { get; set; }
    }
}
