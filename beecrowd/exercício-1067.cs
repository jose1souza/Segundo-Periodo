using System;

class URI
{

    static void Main(string[] args)
    {

        int a,i;
        a = int.Parse(Console.ReadLine());
        i = 1;
        while (i <= a)
        {
            Console.WriteLine($"{i}");
            i = i + 2;
        }

    }

}