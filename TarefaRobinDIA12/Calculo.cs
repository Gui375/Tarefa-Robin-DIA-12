using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//atividade 2

namespace ConsoleCalculo;

    public class Calculo
    {

        public double resultado;
        public double ValorA;
        public double ValorB;
        public void ImprimirResultado()
        {
            Console.WriteLine(resultado);
        }

        public void CalcularSoma()
        {
            resultado = ValorA + ValorB;
        }

        public void CalcularMulti()
        {
            resultado = ValorA * ValorB;
        }

        public void CalcularSubs()
        {
            resultado = ValorA - ValorB;
        }
        public void RetornarMaior()
        {
            int maior = int.MinValue;
            if (ValorA > maior)
            {
                resultado = ValorA;
                if (resultado > ValorB)
                {
                    Console.WriteLine("Valor B é maior");
                }
                else
                {
                    Console.WriteLine("Valor A é maior");
                }
            }
        }

        public void SomarGeral(double geral)
        {
            double G = geral;
            resultado = G + ValorA + ValorB;
        }

    }
