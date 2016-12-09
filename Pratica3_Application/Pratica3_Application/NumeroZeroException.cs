using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class NumeroZeroException : Exception
    {
        private const string mensagem = "Não é permitido valores zerados!" ;

        public NumeroZeroException(): base(mensagem)
        {
        }
        public NumeroZeroException(String msg) : base(msg) { }
    }
}
