using Point_of_sale_app.BL;
using System;
using System.Collections.Generic;
using Point_of_sale_app.DL;
namespace Point_of_sale_app.UI
{
    internal class Ui
    {
        public static User take_input_user()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Password : ");
            string password = Console.ReadLine();
            User input = new User(name, password);
            return input;
        }

        public static char admin_menu()
        {
            Console.Clear();
            Console.WriteLine("////////////         ADMIN MENU        ///////////////////");
            Console.WriteLine("");
            Console.WriteLine("1) Add Products");
            Console.WriteLine("2) View All products");
            Console.WriteLine("3) Find Products with the highest price");
            Console.WriteLine("4) View sales tax on all products");
            Console.WriteLine("5) Products to be Ordered");
            Console.WriteLine("6) EXIT");
            char op = Console.ReadLine()[0];
            return op;
        }

        public static Products take_input_product()
        {
            Products input = new Products();
            Console.Write("Enter the name of product : ");
            input.name = Console.ReadLine();
            Console.Write("Enter the Type of product : ");
            input.type = Console.ReadLine();
            Console.Write("Enter the Price of product : ");
            input.price = float.Parse(Console.ReadLine());
            Console.Write("Enter the Quantity of product : ");
            input.quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minimum Quantity of product : ");
            input.min_quantity = int.Parse(Console.ReadLine());
            input.cal_tax();
            Console.WriteLine("Product has been added .");
            return input;
        }

        public static void display_products(List<Products> products)
        {
            Console.WriteLine("Name\tPrice\tType\tquanity\tMin.Q");
            Console.WriteLine("");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].name + "\t" + products[i].price + "\t" + products[i].type + "\t" + products[i].quantity + "\t" + products[i].min_quantity);
            }
        }

        public static void display_highest(Products products)
        {
            Console.WriteLine("Name\tPrice\tType\tquanity\tMin.Q\tTax");
            Console.WriteLine("");
            Console.WriteLine(products.name + "\t" + products.price + "\t" + products.type + "\t" + products.quantity + "\t" + products.min_quantity + "\t" + products.tax);
        }

        public static void display_taxes(List<Products> products)
        {
            Console.WriteLine("Name\tPrice\tTax");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].name + "\t" + products[i].price + "\t" + products[i].tax);
            }
        }

        public static void to_order(List<Products> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].quantity < products[i].min_quantity)
                {
                    Console.WriteLine("You have to order " + products[i].name);
                }
            }
        }

        public static char menu()
        {
            Console.Clear();
            Console.WriteLine("1) Sign UP");
            Console.WriteLine("2) Sign IN");
            Console.WriteLine("EXIT");
            Console.Write("Enter any option...");
            char op = Console.ReadLine()[0];
            return op;
        }

        public static void clear_screen()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static  char cust_menu()
        {
            Console.Clear();
            Console.WriteLine("1) View All produtcs");
            Console.WriteLine("2) Buy Product");
            Console.WriteLine("3) Generate invoice");
            Console.WriteLine("4) EXIT");
            char op = Console.ReadLine()[0];
            return op;
        } 
        public static void buy_product(List<Products> products, List<Products> buyproducts)
        {
            Console.WriteLine("Enter the name product : ");
            string name = Console.ReadLine();
            int index=UserCRUD.check_buyproduct(name);
            if ( index!= -1)
            {
                products[index].quantity--;
                buyproducts.Add(products[index]);
                Console.WriteLine("Product has been added successfully .");
            }
            else
            {
                Console.WriteLine("Product Does not exist .");
            }
        }
        public static void invoice(float total)
        {
            Console.WriteLine("Your Total is "+total);
        }
    }
}