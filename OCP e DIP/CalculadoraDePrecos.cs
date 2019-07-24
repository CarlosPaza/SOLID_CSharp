using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_e_DIP
{
    public class CalculadoraDePrecos
    {
        private IServicoEntrega _servicoEntrega;
        private ITabelaDePreco _tabela;

        public CalculadoraDePrecos(IServicoEntrega servicoEntrega, ITabelaDePreco tabela)
        {
            _servicoEntrega = servicoEntrega;
            _tabela = tabela;
        }

        public double Calcula(Compra produto)
        {
            double desconto = _tabela.DescontoPara(produto.Valor);
            double frete = _servicoEntrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
