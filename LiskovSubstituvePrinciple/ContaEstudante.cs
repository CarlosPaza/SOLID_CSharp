using System;

namespace LiskovSubstituvePrinciple
{
    public class ContaEstudante : IConta
    {
        private ManipuladorDeSaldo _manipulador;
        public int Milhas { get; private set; }
        public double Saldo {
            get => _manipulador.Saldo;
        }

        public ContaEstudante()
        {
            _manipulador = new ManipuladorDeSaldo();
        }

        public void Deposita(double valor)
        {
            _manipulador.Deposita(valor);
            this.Milhas += (int)valor;
        }

        public void SomaInvestimento()
        {
            _manipulador.SomaInvestimento(1);
        }

        public void Saca(double valor)
        {
            _manipulador.Saca(valor);
        }
    }
}