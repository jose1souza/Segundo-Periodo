using System;
class Program
{
    static void Main()
    {
        double A, B, X;
        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        X = (A * 3.5 + B * 7.5) / 11;
        Console.WriteLine($"MEDIA = {X:F5}");
    }
}
