using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class NaoExisteCiruloEsferaException : Exception 
    {
        private const string mensagem = "Não existe nenhuma forma circulo/esfera para verificar";

        public NaoExisteCiruloEsferaException(): base(mensagem){}
        public NaoExisteCiruloEsferaException(String msg) : base(msg) { }
    }
}
