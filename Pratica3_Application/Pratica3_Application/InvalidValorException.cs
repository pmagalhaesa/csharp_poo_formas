using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class InvalidValorException : Exception 
    {
        private const string mensagem = "Valor númerico incorreto!";

        public InvalidValorException(): base(mensagem){}
        public InvalidValorException(String msg) : base(msg) { }
    }
}
