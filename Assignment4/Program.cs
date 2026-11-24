namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = {25.5, 40.0, 33.75 };
            for(int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i]);
            }
            int[,]shelfCopyies = { {3,1}, {5,4} };
            for(int i = 0; i < shelfCopyies.GetLength(0); i++)
            {
                for(int j = 0; j <shelfCopyies.GetLength(1); j++)
                {
                    Console.WriteLine(shelfCopyies[i,j]);
                }
            }
            PrintBookTitle("clean code");
            AddBonusPages(400);// excepect the value will sum this value plus 50
            ApplyDiscount(prices);
            int pages = 100;
            AddBonusPagesByRef(ref pages);//the excpected reuslt 100 but the actual result become user input becuse ref make varible=value in method
            foreach (int price in prices)
            {
                ReplaceArray(ref prices);
                Console.WriteLine(prices.Length);
                break;
            }
            double Price = 21;
            TryGetPrice("clean code",out Price);
            Console.WriteLine(Convert.ToDouble(Price));
            PrintBookInfo("data stucture");
            PrintBookInfo("algorithms", 700);
            PrintBookInfo(title: "software engineering", pages: 800);
            PrintBookInfo(pages:700,title: "Math");
            PrintAllTitles("c++", "c#", "java");
        }
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine(title);
        }
        public static void AddBonusPages(int pages)
        {
            pages += 50;
            Console.WriteLine(pages);
        }
        public static void ApplyDiscount(double[] prices)
        {
            Console.WriteLine(prices[0]-5);
        }
        public static void AddBonusPagesByRef(ref int pages)
        {
            Console.WriteLine("enter Pages");
            pages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pages);
        }
        public static void ReplaceArray(ref double[] prices)
        {
          prices =new double[]{ 10.0, 12.5,15.0};
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i]);
            }
        }
        public static bool TryGetPrice(string title, out double price)
        {
            if(title=="clean code ")
            {
                price =25.5;
                return true;
            }else
            {
                price = 0;
                return false;
            }
        }
        public static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"title:{title},pages :{ pages}");
        }
   public static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
            
        }
    }
}
