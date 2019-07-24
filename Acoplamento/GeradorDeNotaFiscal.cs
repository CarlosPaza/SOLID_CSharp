using System;
using System.Collections.Generic;
using System.Text;

namespace Acoplamento
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> _listaAcoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> listaAcoes)
        {
            _listaAcoes = listaAcoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {

            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));

            foreach (var acao in _listaAcoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor)
        {
            return valor * 0.06;
        }
    }
}
