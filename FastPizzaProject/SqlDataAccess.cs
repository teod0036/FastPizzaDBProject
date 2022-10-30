using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPizzaProject
{
    internal class SqlDataAccess
    {
        public static List<MealsModel> ReadMeals()
        {

        }

        public static void CreateMeals()
        {

        }

        public static void UpdateMeals()
        {

        }

        public static void DeleteMeals()
        {

        }

        public static List<UsersModel> ReadUsers()
        {

        }

        public static List<RestaurantsModel> ReadRestaurants()
        {

        }

        public static List<InventoryModel> ReadInventory()
        {

        }

        public static void UpdateInventory()
        {

        }

        public static List<OrdersModel> ReadOrders()
        {

        }

        public static void CreateOrders()
        {

        }

        public static void DeleteOrders()
        {

        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
