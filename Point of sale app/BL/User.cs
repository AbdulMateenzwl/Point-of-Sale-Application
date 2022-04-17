using System.Collections.Generic;

namespace Point_of_sale_app.BL
{
    internal class User
    {
        public string name;
        public string role;
        public string password;

        public User()
        { }

        public User(string name, string pass, string rolee)
        {
            this.name = name;
            this.password = pass;
            if (rolee == "1")
            {
                this.role = "Admin";
            }
            else
            {
                this.role = "Customer";
            }
        }

        public User(string name, string pass)
        {
            this.name = name;
            this.password = pass;
            this.role = "Customer";
        }
    }
}