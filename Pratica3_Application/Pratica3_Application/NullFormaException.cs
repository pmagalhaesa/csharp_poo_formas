using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class NullFormaException : Exception 
    {
        private const string mensagem = "Forma inválida";

        public NullFormaException(): base(mensagem){}
        public NullFormaException(String msg) : base(msg) { }
    }
}
