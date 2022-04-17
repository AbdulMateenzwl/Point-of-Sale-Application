using Point_of_sale_app.BL;
using System.Collections.Generic;

namespace Point_of_sale_app.DL
{
    internal class UserCRUD
    {
        public static List<User> users = new List<User>();
        public static List<Products> products = new List<Products>();
        public static List<Products> buy_products = new List<Products>();


        public static int if_exists(User chk)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].name == chk.name &&users[i].password == chk.password  && users[i].role == "Admin")
                {
                    return 1;
                }
                else if (users[i].name == chk.name && users[i].password == chk.password && users[i].role == "Customer")
                {
                    return 2;
                }
            }
            return 3;
        }

        public static void ADD_User(User input)
        {
            users.Add(input);
        }

        public static void ADD_Product(Products input)
        {
            products.Add(input);
        }
        public static void ADD_buyproduct(Products input)
        {
            buy_products.Add(input);
        }

        public static List<Products> get_products()
        {
            return products;
        }
        public static List<Products> get_buyproducts()
        {
            return buy_products;
        }

        public static Products get_highest()
        {
            int index = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].price > products[index].price)
                {
                    index = i;
                }
            }
            return products[index];
        }
        public static int check_buyproduct(string str)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].name==str)
                {
                    return i;
                }
            }
            return -1;
        }
        public static float cal_total()
        {
            float total = 0;
            for (int i = 0; i < buy_products.Count; i++)
            {
                total = total + buy_products[i].price;
            }
            return total;
        }
    }
}