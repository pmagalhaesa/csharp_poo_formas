using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class Quadrado : FormaBidimensional, IForma
    {
        private double lado;

        public Quadrado(double x, double y, double lado, string nome)
        {
            if (lado == 0)
            {
                throw new NumeroZeroException();
            }
            else if (lado < 0)
            {
                throw new NumeroNegativoException();
            }
            this.lado = lado;
            this.setNome(nome);
            this.setX(x);
            this.setY(y);
        }

        public double getLado()
        {
            return this.lado;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public double calculaArea()
        {
            return Math.Pow(this.lado, 2);
        }

        public override string getDescricao()
        {
            return "Quadrado "+ base.getDescricao()+ "\nlado: " + this.getLado() + "\narea: "+ this.calculaArea();
        }
    }
}
