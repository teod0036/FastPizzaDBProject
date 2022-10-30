using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPizzaProject
{
    internal class SqlDataAccess
    {
        public static List<MealsModel> ReadMeals()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MealsModel>("SELECT * FROM Meals", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void CreateMeals(MealsModel meal)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Meals (Meal) VALUES (@Meal)", meal);
            }
        }

        public static void UpdateMeals(MealsModel meal, int ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Meals SET " + ID + " = @Meal", meal);
            }
        }

        public static void DeleteMeals(MealsModel meal, int ID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE FROM Meals WHERE Meal_ID = " + ID, meal);
            }
        }

        public static List<UsersModel> ReadUsers(UsersModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UsersModel>("SELECT * FROM Meals", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<RestaurantsModel> ReadRestaurants(RestaurantsModel restaurant)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<RestaurantsModel>("SELECT * FROM Meals", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<InventoryModel> ReadInventory(InventoryModel Inventory)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InventoryModel>("SELECT * FROM Meals", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void UpdateInventory(InventoryModel Inventory)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

            }
        }

        public static List<OrdersModel> ReadOrders(OrdersModel order)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<OrdersModel>("SELECT * FROM Meals", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void CreateOrders(OrdersModel order)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO orders (Meal_ID, Restaurant_ID, USER_ID) VALUES (@Meal_ID, @Restaurant_ID, @USER_ID)", order);
            }
        }

        public static void DeleteOrders(OrdersModel order)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
