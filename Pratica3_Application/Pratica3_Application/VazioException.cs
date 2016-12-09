using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class VazioException : Exception 
    {
        private const string mensagem = "Não é permitido campos vazios";

        public VazioException(): base(mensagem){}
        public VazioException(String msg) : base(msg) { }
    }
}
