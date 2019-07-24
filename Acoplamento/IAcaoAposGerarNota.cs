using System;
using System.Collections.Generic;
using System.Text;

namespace Acoplamento
{
    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }
}
