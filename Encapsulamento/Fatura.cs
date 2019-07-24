using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        private List<Pagamento> _pagamentos;
        public bool Pago { get; private set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this._pagamentos = new List<Pagamento>();
            this.Pago = false;
        }

        public void AdicionarPagamento(Pagamento pagamento)
        {
            _pagamentos.Add(pagamento);

            if (ValorTotalDosPagamentos() >= Valor)
                Pago = true;
        }

        private double ValorTotalDosPagamentos()
        {
            double total = 0;

            foreach (var pag in _pagamentos)
                total += pag.Valor;

            return total;
        }
    }
}
