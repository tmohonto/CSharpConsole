using System;

namespace StaticClass
{
    class Program
    {
        static class product
        {
            public static int productId;
            public static string productName;
            public static int productPrice;

            static product()
            {
                productId = 111;
                productName = "Flute";
                productPrice = 5000;
            }
            public static void getProductDetails()
            {
                Console.WriteLine("Product id = {0}",productId);
                Console.WriteLine("Product name = {0}",productName);
                Console.WriteLine("Product price = {0}",productPrice);
            }
            public static void getDiscount()
            {
                int discountAmount = productPrice / 5;
                Console.WriteLine("Your discount amount is: {0}",discountAmount);
                Console.WriteLine("Your discount amount is: {0}",(productPrice-discountAmount));
            }
        }
        static void Main(string[] args)
        {
            product.getProductDetails();
            product.getDiscount();
        }
    }
}
