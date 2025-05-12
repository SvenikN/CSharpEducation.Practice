using System;

public class Program
{
    public static void Main(string[] args)
    {
        int size = Convert.ToInt32(args[0]);
        int[] MyRandMassiv = RandMassiv(size);
        WriteMassiv(MyRandMassiv);
    }

        static int[] RandMassiv(int size)
        {
            int[] myArray = new int[size];

            Random r = new Random();

            for (int i = 0; i < size; i++)
                myArray[i] = r.Next(1, 50);
            return myArray;
        }

        static void WriteMassiv(int[] MyRandMassiv)
        {
            foreach (var i in MyRandMassiv) 
                Console.Write(i + " ");
        }
}