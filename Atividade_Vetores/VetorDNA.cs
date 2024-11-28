using System;

    internal class VetorDNA
{
    static void Main()
    {
        int n;
        char dna;

        do
        {
            Console.WriteLine("Digite a quantidade de caracteres(Minimo de 1 e máximo de 50!!)");
            n = int.Parse(Console.ReadLine());
        } while (n > 50 || n <= 0);

        char[] letra = new char[n];

        for (int i = 0; i < n; i++)
        {
            do
            {
                Console.WriteLine("Digite A, T, G ou C: ");
                dna = char.Parse(Console.ReadLine().ToUpper());
            } while (dna != 'A' && dna != 'T' && dna != 'G' && dna != 'C');
            letra[i] = dna;

            if (letra[i] == 'A')
            {
                Console.Write($"{dna}==T\n");
            }

            else if (letra[i] == 'T')
            {
                Console.Write($"{dna}==A\n");
            }

            else if (letra[i] == 'G')
            {
                Console.Write($"{dna}==C\n");
            }
            else
            {
                Console.Write($"{dna}==G\n");
            }
        }

    }
 }

