using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp;
internal class Exercicio06
{
    public static void Execute()
    {
        /*06 - Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:*/
        Console.WriteLine("---------------------------------");
        Console.WriteLine("EXERCÍCIO 06");
        Console.WriteLine("---------------------------------");

        DateTime dateTime = DateTime.UtcNow;

        Console.WriteLine($"{dateTime.ToString(new CultureInfo("pt-BR"))}");
        Console.WriteLine($"{dateTime.ToString("d", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"{dateTime.ToString("HH:mm:ss", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"{dateTime.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"))}");
    }
}
