using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp;
internal class Exercicio04
{
    public static void Execute()
    {
        /*04 - Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.*/

        Console.WriteLine("---------------------------------");
        Console.WriteLine("EXERCÍCIO 04");
        Console.WriteLine("---------------------------------");

        Console.WriteLine($"Informe uma frase:");
        string frase = Console.ReadLine();
        string fraseSemEspaco = frase.Replace(" ", "");
        int quantidade = 0;

        //Console.WriteLine($"Quantidade de Caracteres: {fraseSemEspaco.Length}");

        for (int i = 0; i < fraseSemEspaco.Length; i++)
        {
            quantidade++;
        }

        Console.WriteLine($"Quantidade de Caracteres: {quantidade}");
    }
}
