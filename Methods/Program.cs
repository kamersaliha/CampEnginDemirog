namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
         Product product1 = new Product();
            product1.Name = "Apple";    
            product1.Description = "Amasya Elması";
            product1.Price = 10;

         Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Description = "Diyarbakır Karpuzu";
            product2.Price = 80;

            Product[] products = new Product[] { product1, product2 };
            
            foreach (var product in products) 
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.Price);
                Console.WriteLine("----------");
            }
            Console.WriteLine("------Methods--------");

            // instance
            // encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil armut", 12,190);
            sepetManager.Add2("Elma", "Yeşil Elma", 20, 293930);
        }
    }
}