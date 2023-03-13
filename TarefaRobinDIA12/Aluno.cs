using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//atividade 1
namespace atd
{
    public class Aluno
    {
        public string nome;
        public string RA;
        public decimal NotaProva;
        public decimal NotaTrabalho;
        public decimal NotaFinal;
        bool Final = false;

        public void ReceberDados()
        {

            Console.WriteLine("Preencha seu RA: ");
            RA = Console.ReadLine();

            Console.WriteLine("Preencha seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Preencha a nota do seu trabalho: ");
            NotaTrabalho = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Preencha a nota da sua prova: ");
            NotaProva = decimal.Parse(Console.ReadLine());

        }
        public void Dados() {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"RA: {RA}");
        }

        private void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;

        }

        private void CalcularNotaFinal()
        {
            
            CalcularMedia();

            if (NotaFinal >= 6)
            {
                Final = true;    
            }         
        }

        public void Aprovado()
        {
            CalcularNotaFinal();

            if (Final ==true)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
        }

        
    


    }
}
