List<int> fib = new List<int>();
int i=0;
fib.Add(i);
while (fib[i] < 1000000)
{
    i++;
    if (i == 1)
    {
        fib.Add(1);
        Console.WriteLine(fib[i]);
        continue;
    }
    if (i == 2)
    {
        fib.Add(1);
        Console.WriteLine(fib[i]);
    }
    else 
    {
        fib.Add(fib[i-1]+ fib[i-2] );
        Console.WriteLine(fib[i]);

    }

}
int j=0;
bool p = true;
int cislo= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");
List<int> list = new List<int>();
while (p)
{
    if(cislo == 0)
    {
        p = false;
    }
    else if(cislo < fib[j+1])
    {
        cislo = cislo - fib[j];
        list.Add(fib[j]);
        j = 0;
    }
    else
    {
        j++;
    }
}
for (int k = 0; k < list.Count; k++)
{
    Console.WriteLine(list[k]) ;
}
