using Point_of_sale_app.BL;
using Point_of_sale_app.DL;
using Point_of_sale_app.UI;
using System;

namespace Point_of_sale_app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User first = new User("q", "123","1");
            UserCRUD.ADD_User(first);
            while (true)
            {
                char option = Ui.menu();
                if (option == '1')
                {
                    UserCRUD.ADD_User(Ui.take_input_user());
                    Console.WriteLine("Account created .");
                }
                else if (option == '2')
                {
                    User user = Ui.take_input_user();
                    int chk = UserCRUD.if_exists(user);
                    if (chk == 1)
                    {
                        while (true)
                        {
                            char op = Ui.admin_menu();
                            if (op == '1')
                            {
                                UserCRUD.ADD_Product(Ui.take_input_product());
                            }
                            else if (op == '2')
                            {
                                Ui.display_products(UserCRUD.get_products());
                            }
                            else if (op == '3')
                            {
                                Ui.display_highest(UserCRUD.get_highest());
                            }
                            else if (op == '4')
                            {
                                Ui.display_taxes(UserCRUD.get_products());
                            }
                            else if (op == '5')
                            {
                                Ui.to_order(UserCRUD.get_products());
                            }
                            else
                            {
                                break;
                            }
                            Console.ReadKey();
                        }
                    }
                    if (chk == 2)
                    {
                        while (true)
                        {
                            char op = Ui.cust_menu();
                            if(op=='1')
                            {
                                Ui.display_products(UserCRUD.get_products());
                            }
                            else if(op=='2')
                            {
                                Ui.buy_product(UserCRUD.get_products(), UserCRUD.get_buyproducts());
                            }
                            else if(op=='3')
                            {
                                Ui.invoice(UserCRUD.cal_total());
                            }
                            else
                            {
                                break;
                            }
                            Console.ReadKey();

                        }
                    }
                    else
                    {
                        Console.WriteLine("Account does not exists...");
                    }
                }
                else if (option == '3')
                {
                    break;
                }
                Ui.clear_screen();
            }
        }
    }
}