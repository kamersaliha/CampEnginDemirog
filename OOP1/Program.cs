﻿namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
          Product product1= new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 10;
            product1.UnitsInStock = 100;

          Product product2 = new Product { Id=2, CategoryId = 3, ProductName="Sandalye", UnitPrice=20, UnitsInStock=200};
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
  
        }
    }
}