using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp;
internal class Exercicio01
{
    public static void Execute(){
        /*01 - Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!*/
        Console.WriteLine("---------------------------------");
        Console.WriteLine("EXERCÍCIO 01");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Digite seu nome:");
        var nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }

}
