using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class InvalidCriarException : Exception 
    {
        private const string mensagem = "Você deve selecionar o menu de Nova Forma antes de criar";

        public InvalidCriarException() : base(mensagem) { }
        public InvalidCriarException(String msg) : base(msg) { }
    }
}
