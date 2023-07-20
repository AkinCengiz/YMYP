namespace DrawATriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin yüksekliği : ");
            int step = Convert.ToInt32(Console.ReadLine());

            int[,] triangle = new int[step,step * 2 + 1];
            for (int i = 0; i < step; i++)
            {
                for (int j = 0; j < step * 2 - 1; j++)
                {
                    if (i == 0)
                    {
                        triangle[i,j] = 1;
                    }
                    if (i == j)
                    {
                        triangle[i,j] = 1;
                    }
                    if (j == step - 1)
                    {
                        triangle[i,j] = 1;
                    }
                    if ((i <= step - 1 && j > step - 1) && (j + i > step - 1 && j + i <= (step - 1) * 2))
                    {
                        triangle[i,j] = 1;
                    }
                    if ((j >= i && j < step - 1) && (j - i > 0 && j - i < step - 1))
                    {
                        triangle[i,j] = 1;
                    }
                }
            }
            for (int i = 0; i < step; i++)
            {
                for (int j = 0; j < step * 2 - 1; j++)
                {
                    if (triangle[i,j] == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}