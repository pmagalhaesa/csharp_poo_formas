using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class NumeroNegativoException : Exception
    {
        private const string mensagem = "Não é permitido valores negativos!";

        public NumeroNegativoException(): base(mensagem)
        {
        }
        public NumeroNegativoException(String msg) : base(msg) { }
    }
}
