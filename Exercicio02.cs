using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp;
internal class Exercicio02
{
    public static void Execute()
    {
        /*02 - Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.*/

        Console.WriteLine("---------------------------------");
        Console.WriteLine("EXERCÍCIO 02");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Digite seu nome:");
        var primeiroNome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome:");
        var sobrenome = Console.ReadLine();
        Console.WriteLine($"{primeiroNome} {sobrenome}");
    }
}
