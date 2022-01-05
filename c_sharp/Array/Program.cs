using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] notas = new double [3];
            
           


        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Insira a "+(i+1)+"ª nota");
            notas[i] = double.Parse(Console.ReadLine());
        }

        double soma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }
            double media = soma/3;
            Console.WriteLine(" A média das notas é "+media);
        }
    }
}
