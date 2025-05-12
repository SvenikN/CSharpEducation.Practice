using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        int size = 10;
        int[] MyRandMassiv = RandMassiv(size);
        int[] MasDeleteOtr = DeleteOtr(MyRandMassiv, out int kol);
        
        Console.WriteLine();
        WriteMassiv(MasDeleteOtr);
        Console.WriteLine();
        Console.WriteLine($"количество удаленных чисел = {kol}");
    }

    static int[] RandMassiv(int size)
    {
        int[] myArray = new int[size];
        Random r = new Random();

        for (int i = 0; i < size; i++)
        {
            myArray[i] = r.Next(-20, 20);
            Console.Write(myArray[i] + " ");
        }
        return myArray;
    }

    static int[] DeleteOtr(int[] MyRandMassiv, out int kol)
    {
        List<int> myArray = new List<int>();
        kol = 0;

        for (int i = 0; i < MyRandMassiv.Length; i++)
        {
            if ( MyRandMassiv[i] >= 0)
                myArray.Add(MyRandMassiv[i]);
            
            kol = MyRandMassiv.Length - myArray.Count;
        }

        int[] Array = myArray.ToArray();
        return Array;
    }
    static void WriteMassiv(int[] MasDeleteOtr)
    {
        for (int i = 0; i < MasDeleteOtr.Length; i++)
        {
            Console.Write(MasDeleteOtr[i] + " ");
        }
    }
}
