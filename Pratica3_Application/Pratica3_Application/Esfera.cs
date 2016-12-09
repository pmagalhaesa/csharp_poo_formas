using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class Esfera : FormaTridimensional, IForma, IFormaTriDimensional
    {
        private double raio;

        public Esfera(double x, double y, double z, double raio, string nome)
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
            this.setZ(z);
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
            return 4 * (Math.PI * (Math.Pow(this.raio, 2)));
        }

        public double calculaVolume()
        {
            return (4/3) * ( 4 * (Math.PI * Math.Pow(this.raio, 3)));
        }

        public override string getDescricao()
        {
            return "Esfera " + base.getDescricao() + "(z = " + this.getZ()+")" +"\nraio: " + this.getRaio() + "\narea: " + this.calculaArea() + "\nvolume: " + this.calculaVolume();
        }

        public static bool intercetam(Esfera esfera1, Esfera esfera2)
        {
            return (!esfera1.Equals(esfera2) && (esfera1.getRaio() + esfera2.getRaio()) >= Forma.calculoDistancia(esfera1, esfera2));
        
        }
    }
}
