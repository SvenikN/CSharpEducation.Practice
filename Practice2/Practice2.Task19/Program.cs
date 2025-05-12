using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        int size = 10;
        int[] MyRandMassiv = RandMassiv(size);
        int minMaxRange = MinMaxRange(MyRandMassiv);
        Console.WriteLine();
        Console.WriteLine($"Разница между Max и Min = {minMaxRange}");
    }

    static int[] RandMassiv(int size)
    {
        int[] myArray = new int[size];
        Random r = new Random();

        for (int i = 0; i < size; i++)
        {
            myArray[i] = r.Next(1, 100);
            Console.Write(myArray[i] + " ");
        }
        return myArray;
    }

    static int MinMaxRange(int[] MyRandMassiv)
    {
        int max = MyRandMassiv.Max();
        int min = MyRandMassiv.Min();
        int range = max - min;

        return range;
    }
}
