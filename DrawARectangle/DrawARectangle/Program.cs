namespace DrawARectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dikdörtgenin Genişliği\t\t: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin Yüksekliği\t\t: ");
            int height = Convert.ToInt32(Console.ReadLine());
            bool isFill = false;
            Console.WriteLine("Dikdörgenin içi dolu mu boş mu\t?");
            Console.Write("Dolu ise ( 1 )\tBoş ise ( 0 )\t:");
            string inputValue = Console.ReadLine();
            isFill = (inputValue == "1") ? true : false;
            Console.WriteLine();

            for (int i = 0; i < height ; i++)
            {
                for (int j = 0; j < width ; j++)
                {
                    if (i + j == j || i + j == i || i == height - 1  || j == width - 1)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        if (isFill)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                        
                    }
                }
                Console.WriteLine();
            }

            string statu = isFill ? "Dolu" : "Boş";
            Console.WriteLine("\n---------------------------------\nGenişliği\t: {0,3}\nYüksekliği\t: {1,3}\nolan içi {2,4} dikdörtgen...",width,height,statu);
        }
    }
}