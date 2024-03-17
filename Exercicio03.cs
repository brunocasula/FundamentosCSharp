using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp;
internal class Exercicio03
{
    public static void Execute()
    {
        /*03 - Crie um programa com 2 valores do tipo double já declarados que retorne:*/

        Console.WriteLine("---------------------------------");
        Console.WriteLine("EXERCÍCIO 03");
        Console.WriteLine("---------------------------------");

        Double valor1 = 20.6;
        Double valor2 = 10.3;

        Console.WriteLine($"Valor1: {valor1}");
        Console.WriteLine($"Valor2: {valor2}");
        Console.WriteLine("");

        Console.WriteLine($"Soma: {Math.Round(valor1 + valor2, 2)}");
        Console.WriteLine($"Subtração: {Math.Round(valor1 - valor2, 2)}");
        Console.WriteLine($"Multiplicação: {Math.Round(valor1 * valor2, 2)}");
        Console.WriteLine($"Divisão: {Math.Round(valor1 / valor2, 2)}");
        Console.WriteLine($"Média: {Math.Round((valor1 + valor2) / 2, 2)}");
    }
}
