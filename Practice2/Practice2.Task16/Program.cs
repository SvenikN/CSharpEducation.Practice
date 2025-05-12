
void Change (ref int a) 
{ 
    a = -a;
}

int a = 12;
Console.WriteLine (a);
Change (ref a);
Console.WriteLine(a);