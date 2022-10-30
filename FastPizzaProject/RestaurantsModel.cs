using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPizzaProject
{
    public class RestaurantsModel
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public int Opening_Time { get; set; }
        public int Closing_Time { get; set; }
        public string Contact_Information { get; set; }

    }
}
