using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPrinciple
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraCalculo regra) : base(regra)
        {
        }
    }
}
