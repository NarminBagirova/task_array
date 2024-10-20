namespace Task_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int[] numbers = { 23, 75, 7, 27, 18, 10, 6 };

            //int largest = numbers[0];

            //foreach (int number in numbers)
            //{
            //    if (number > largest)
            //    {
            //        largest = number;
            //    }
            //}

            //Console.WriteLine($"The largest number in the array is: {largest}");
            #endregion

            #region Task2
            var products = new[]
            {
                new{ Id=1, Name="Product 1", Price=13.5, StockCount=99},
                new{ Id=2, Name="Product 2", Price=28.0, StockCount=99},
                new{ Id=3, Name="Product 3", Price=34.2, StockCount=99},
                new{ Id=4, Name="Product 4", Price=42.7, StockCount=99},
                new{ Id=5, Name="Product 5", Price=45.5, StockCount=99},
            };

            double totalPrice = 0;
            int count = 0;

            for(int i=0; i<products.Length; i++)
            {
                if (products[i].Id %2!=0)
                {
                    totalPrice+= products[i].Price;
                    count++;
                    double averagePrice = totalPrice / count;
                    averagePrice = totalPrice / count;
                    Console.WriteLine($"Average price of products with odd IDs: {averagePrice}");
                }
            }
            if(count==0)
            {
                Console.WriteLine("There is no product with odd ID");
            }
           
            
            #endregion
        }
    }
}
