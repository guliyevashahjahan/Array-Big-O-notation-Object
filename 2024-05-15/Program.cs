using System.Net.Http.Headers;

namespace _2024_05_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş ededler siyahisindaki en böyük ededi tapan alqoritm

            int[] numbers = { 23, 54, 3, 5, 17 };
            int max = numbers.Max();
           
            Console.WriteLine(max);

            //Verilmiş Products arrayindəki Product objectlərinin Id'ləri tək olanlarının
            //Price'larının ədədi ortasını tapan algorithm yazın
            //(Product objectinin propertyləri: Id(yeni reqem ve ya eded), Name, Price, StockCount)

            Product[] products = new Product[4];
            products[0] = new Product(1, "Book", 6.5, 12);
            products[1] = new Product(2, "Pencil", 2, 43);
            products[2] = new Product(3, "Glue", 4.3, 24);
            products[3] = new Product(4, "Ruller", 3, 32);

            double sum = 0;
            int count = 0;

            foreach (var item in products)
            {
                if (item.Id % 2 != 0)
                {
                    sum += item.Price;
                    count++;
                }
            }
            Console.WriteLine(sum/count);

        }
    }
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double StockCount { get; set; }
        public Product(int id,string name, double price, double stockCount)
        {
            Id = id;
            Name = name;
            Price = price;
            StockCount = stockCount;
        }
    }
   
}
