using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class Circulo : FormaBidimensional, IForma
    {

        private double raio;

        public Circulo(double x, double y, double raio, string nome)
        {
            if (raio == 0)
            {
                throw new NumeroZeroException();
            }
            else if (raio < 0)
            {
                throw new NumeroNegativoException();
            }
            this.raio = raio;
            this.setNome(nome);
            this.setX(x);
            this.setY(y);
        }

        public double getRaio()
        {
            return this.raio;
        }

        public void setRaio(double raio)
        {
            this.raio = raio;
        }

        public double calculaArea()
        {
            return Math.PI * (Math.Pow(this.raio, 2));
        }

        public override string getDescricao()
        {
            return "Circulo " + base.getDescricao()+"\nraio: " + this.getRaio() + "\narea: "+ this.calculaArea();
        }

       
        public static bool intercetam(Circulo circulo1, Circulo circulo2)
        {
            return (!circulo1.Equals(circulo2) && (circulo1.getRaio() + circulo2.getRaio()) >= Forma.calculoDistancia(circulo1, circulo2));
        }
    }
}
