using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _231445_231224
{
    internal class Program
    {
        public static double saldo = 0;
        
        static void deposito()
        {
            Console.WriteLine("Insira o Valor que deseja Depositar: ");
            double deposito = double.Parse(Console.ReadLine());

            saldo += deposito;

            Console.WriteLine("Foi Feito um depósito de R$" + deposito + 
                " em sua conta, seu saldo atual é de R$ " + saldo);     
        }
        static void saque()
        {
            Console.WriteLine("Insira valor do saque a ser efetuado: ");
            double saque = double.Parse(Console.ReadLine());

            if (saldo >= saque)
            {
                saldo -= saque;
                Console.WriteLine("Foi Feito um saque de R$" + saque +
          " em sua conta, seu saldo atual é de R$ " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente.");
            }

        }
        static void pagamento()
        {
            Console.WriteLine("Insira valor do Pagamento a ser efetuado: ");
            double pagamento = double.Parse(Console.ReadLine());

            if (saldo >= pagamento)
            {
                saldo -= pagamento;
                Console.WriteLine("Foi Feito um pagamento de R$" + pagamento +
          " em sua conta, seu saldo atual é de R$ " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente.");
            }           
        }
        static void consulta()
        {
            Console.WriteLine("Seu saldo Atual é de R$ "+saldo);
        }
        static void operacao()
        {
            Console.WriteLine("Insira a ação que deseja fazer: 1(Depósito) 2(Saque) 3(Pagamento) 4(Saldo)");
            int Opr = int.Parse(Console.ReadLine());

            switch (Opr)
            {
                case 1:
                    deposito();
                    
                    break;
                case 2:
                    saque();
                    break;
                case 3:
                    pagamento();
                    break;
                case 4:
                    consulta();
                    break;
                default:
                    Console.WriteLine("Operação Inválida!");
                    break;
            }

        }
        static void Main(string[] args)
        {
           int resp = 0;

            while (resp == 0) { 
                operacao();
                Console.WriteLine("Deseja Continuar? 0(sim) 1(não)");
                resp = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Volte Sempre!");

            Console.ReadKey();
        }
    }
}
