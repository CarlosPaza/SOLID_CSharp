using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstituvePrinciple
{
    public class ProcessadorDeInvestimentos
    {

        static void Main(string[] args)
        {
            IList<IConta> contas = ContasDoBanco();

            foreach (IConta conta in contas)
            {
                conta.SomaInvestimento();

                Console.WriteLine("Novo saldo: " + conta.Saldo);
            }


            Console.ReadLine();
        }

        private static IList<IConta> ContasDoBanco()
        {
            List<IConta> contas = new List<IConta>();
            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaEstudante(100));
            return contas;
        }

        private static ContaEstudante umaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum umaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }
    }
}
