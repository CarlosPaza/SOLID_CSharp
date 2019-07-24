using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPrinciple
{
    public abstract class Cargo
    {
        public IRegraCalculo Regra { get; private set; }

        public Cargo(IRegraCalculo regra)
        {
            Regra = regra;
        }
    }
}
