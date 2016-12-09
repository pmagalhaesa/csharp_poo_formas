using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class VetorVazioException : Exception 
    {
        private const string mensagem = "Vetor de formas nao possui nenhuma forma";

        public VetorVazioException(): base(mensagem){}
        public VetorVazioException(String msg) : base(msg) { }
    }
}
