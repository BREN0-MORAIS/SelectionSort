using System;
using System.Collections.Generic;
using System.Text;

public static class Program
{
    static void Main(string[] args)
    {

        int[] vetor = new int[7];
        int min, aux;

        //inserindo dados
        for (int i = 0; i<= vetor.Length-1; i++)
        {
            Console.WriteLine("Digite");
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < vetor.Length - 1; i++)
        {

            min = i;
            for (int j = i + 1; j < vetor.Length; j++)
                if (vetor[j] < vetor[min])

                    min = j;

            if (min != i)
            {

                aux = vetor[min];

                vetor[min] = vetor[i];

                vetor[i] = aux;
            }
        }

        for (int i = 0; i <= vetor.Length-1; i++)
        {
            Console.WriteLine(vetor[i]);
        }

        Console.ReadLine();
    }

    public static void V()
    {
        int[] p = new int[7];
        int c, es, d, aux;

        for (c = 0; c <= 6; c++)
        {
            Console.WriteLine("Digite um Valor");
            p[c] = Convert.ToInt32(Console.ReadLine());
        }

        for (es = 0; es <= 6; es++)
        {
            for (d = es; d <= 6; d++)
            {
                if (p[es] > p[d])
                {
                    aux = es;
                    p[es] = p[d];
                    p[d] = aux;

                }

            }
        }

        Console.Clear();

        //ordenar os valores

        for (c = 0; c <= 6; c++)
        {
            Console.WriteLine(p[c]);
        }
        Console.ReadLine();
    }
}



