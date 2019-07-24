using System;

namespace LiskovSubstituvePrinciple
{
    class ContaComum : IConta
    {
        private ManipuladorDeSaldo _manipulador;
        public double Saldo
        {
            get => _manipulador.Saldo;
        }

        public ContaComum()
        {
            _manipulador = new ManipuladorDeSaldo();
        }

        public void SomaInvestimento()
        {
            _manipulador.SomaInvestimento(1.1);
        }

        public void Saca(double valor)
        {
            _manipulador.Saca(valor);
        }

        public void Deposita(double valor)
        {
            _manipulador.Deposita(valor);
        }
    }
}