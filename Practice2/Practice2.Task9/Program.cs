
int size = 5;
int[] MyRandMassiv = RandMassiv(size);

WriteMassiv(MyRandMassiv);

static int[] RandMassiv(int size) 
{
    int[] myArray = new int[size];
    Random r = new Random();

    for (int i = 0; i < size; i++)
        myArray[i] = r.Next(1, 50);
    return myArray;
}

void WriteMassiv(int[] MyRandMassiv) 
{
    for (int i = 0; i < MyRandMassiv.Length; i++)
        Console.Write(MyRandMassiv[i] + " ");
}