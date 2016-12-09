using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class LimiteVetorException : Exception 
    {
        private const string mensagem = "Tamanho máximo do vetor atingido!";

        public LimiteVetorException(): base(mensagem){}
        public LimiteVetorException(String msg) : base(msg) { }
    }
}
