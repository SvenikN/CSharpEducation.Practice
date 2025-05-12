class Practice2
{
    static void Main(string[] args)
    {
        Triangle();
        //ReverseTriangle();

        void Triangle()
        {
            // Задайте высоту треугольника
            int height = 6;

            string[,] num = new string[height, height];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    num[i, j] = "*";
                    Console.Write($"{num[i, j]}");
                }

                Console.WriteLine();
            }
        }

        void ReverseTriangle() 
        {
            // Задайте высоту треугольника
            int height = 6;

            string[,] num = new string[height, height];

            for (int i = 0; i < height; i++)
            {
                for (int j = height-1; j >= height-1-i; j--)
                {
                    num[i, j] = "*";
                    Console.Write($"{num[i, j]}");
                }

                Console.WriteLine();
            }

        }


    }
}