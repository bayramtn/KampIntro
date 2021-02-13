using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {id=2,CategoryId=5,UnitsInStock=5,ProductName="Kaleme",UnitPrice=35 };

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //productManager.Topla2(3, 6);
            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);
            

            


              

        }
    }
}
