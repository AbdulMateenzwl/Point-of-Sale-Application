namespace Point_of_sale_app.BL
{
    internal class Products
    {
        public string name;
        public float price;
        public string type;
        public float quantity;
        public int min_quantity;
        public float tax;

        public void cal_tax()
        {
            if (type == "grocery")
            {
                tax = price * 0.1f;
            }
            else if (type == "fruit")
            {
                tax = price * 0.05f;
            }
            else
            {
                tax = price * 0.15f;
            }
        }

        public float get_tax()
        {
            return tax;
        }
    }
}