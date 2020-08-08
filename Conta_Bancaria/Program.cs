using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Conta_Bancaria {
    class Program {
        static void Main(string[] args) {

                       
            Console.Write("Entre o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
           
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char sim_Ou_Nao = char.Parse(Console.ReadLine());
            
            Console.Write("Entre o valor de depósito inicial: ");
            double deposito_Inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            ContaBancaria conta = new ContaBancaria(numeroDaConta, nome, sim_Ou_Nao, deposito_Inicial, 5.00);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");           
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            conta.Taxa(5.00);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);




        }
    }
}
