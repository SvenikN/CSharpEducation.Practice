using System;

public class Program
{
    public static void Main(string[] args)
    {
        int size = Convert.ToInt32(args[0]);
        int mas = Convert.ToInt32(args[1]);
        int[] MyRandMassiv = RandMassiv(size);

        WriteMassiv(MyRandMassiv, mas);
    }

    static int[] RandMassiv(int size)
    {
        int[] myArray = new int[size];
        Random r = new Random();

        for (int i = 0; i < size; i++)
            myArray[i] = r.Next(1, 50);
        return myArray;
    }
    static void WriteMassiv(int[] MyRandMassiv, int mas)
    {
        for (int i = 0; i < MyRandMassiv.Length; i++)
        {
            MyRandMassiv[i] = mas;
            Console.Write(MyRandMassiv[i] + " ");
        }
    }
}