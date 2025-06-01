
namespace Animals;

class Program
{
    public static void Main(string[] args)
    {
        Cat c = new Cat("AAA", 2);
        c.MakeSound();

        Dog d = new Dog("AAA", 4);
        d.MakeSound();

        Console.Write("Попугай скажи - ");
        string world = Console.ReadLine();
        if (world != null)
        {
            Parrot p = new Parrot("PPP", 7, System.Drawing.Color.Blue);
            p.MakeSound(world);
        }
        else Console.WriteLine("Попугай молчит");

        IFlyable[] fl = new IFlyable[3];
        fl[0] = new Parrot("www", 3, System.Drawing.Color.Red);
        fl[1] = new Eagle();
        fl[2] = new Eagle();

        foreach (IFlyable f in fl)
        {
            f.Fly();
        }
    }  
}