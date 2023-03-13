using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCalculo;


namespace consoleCalculadora;



public class Calculadora : Calculo
{

    public void Lervalores()
    {
        Console.WriteLine("Digite o valor d A :");
        ValorA = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor d B :");
        ValorB = double.Parse(Console.ReadLine());
    }
    public void ExCalculadora()
    {

        Console.WriteLine("Em qual opção você deseja entrar?: ");
        int menuop = int.Parse(Console.ReadLine());
        Console.WriteLine("Somar");
        Console.WriteLine("Multiplicar");
        Console.WriteLine("Subtrair");
        Console.WriteLine("Retornar maior");
        Console.WriteLine("Somar geral");

        switch (menuop)
        {
            case 1:
                CalcularSoma();
                ImprimirResultado();
                break;

            case 2:
                CalcularMulti();
                ImprimirResultado();
                break;

            case 3:
                CalcularSubs();
                ImprimirResultado();
                break;

            case 4:
                RetornarMaior();
                ImprimirResultado();
                break;

            case 5:
                Console.WriteLine("Digite um valor a ser somado junto com as as duas variaveis: ");
                double valoradd = double.Parse(Console.ReadLine());
                SomarGeral(valoradd);
                ImprimirResultado();
                break;

        }
    }

}
