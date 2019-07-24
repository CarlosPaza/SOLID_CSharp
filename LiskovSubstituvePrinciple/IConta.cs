using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstituvePrinciple
{
    public interface IConta
    {
        double Saldo { get; }
        void Deposita(double valor);
        void Saca(double valor);
        void SomaInvestimento();      
    }
}
