using System;
class Program
{
    static void Main()
    {
        double area, raio;
        const double PI = 3.14159;
        raio = double.Parse(Console.ReadLine());
        area = PI * (raio * raio);
        Console.WriteLine($"A={area:F4}");
        Console.ReadKey();
    }
}
