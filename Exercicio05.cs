using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSharp;
internal class Exercicio05
{
    public static void Execute()
    {
        /*05 Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:*/

        Console.WriteLine("---------------------------------");
        Console.WriteLine("EXERCÍCIO 05");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("Informe a placa:");
        string placa = Console.ReadLine();

        bool ValidaPlaca(string placa)
        {
            if (!(placa.Trim().Length == 7))
            {
                return false;
            }

            string placaString = placa.Trim().Substring(0, 3);

            foreach (char c in placaString)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }

            string placaNumeric = placa.Trim().Substring(3, 4);

            foreach (char c in placaNumeric)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        if (ValidaPlaca(placa))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

    }
}
