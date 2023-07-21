namespace TriangleFillAndEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin taban uzunluğu : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                a++;
            }
            Console.WriteLine("======================================\n\n");
            int[,] triangle = new int[a, a];
            
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if ((i + j) == a / 2)
                    {
                        triangle[i, j] = 1;
                    }

                    if ((j - i) == a / 2)
                    {
                        triangle[i, j] = 1;
                    }

                    if (i == a / 2)
                    {
                        triangle[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i <= triangle.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= triangle.GetUpperBound(1); j++)
                {
                    if (triangle[i, j] == 1)
                    {
                        Console.Write("{0,3}", "*");
                    }
                    else
                    {
                        Console.Write("{0,3}", " ");
                    }
                }
            }
        }
    }
}