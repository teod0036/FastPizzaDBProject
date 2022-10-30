using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPizzaProject
{
    internal class OrdersModel
    {
        public int ID { get; set; }
        public int Meal_ID { get; set; }
        public int Restaurant_ID { get; set; }
        public int User_ID { get; set; }

    }
}
