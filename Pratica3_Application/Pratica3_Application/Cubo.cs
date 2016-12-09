using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class Cubo : FormaTridimensional, IForma, IFormaTriDimensional
    {
        private double lado;

        public Cubo(double x, double y, double z, double lado, string nome)
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
            this.setZ(z);
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
            return 6 * (Math.Pow(this.lado, 2));

        }

        public double calculaVolume()
        {
            return Math.Pow(this.lado, 3);
        }

        public override string getDescricao()
        {
            return "Cubo "+ base.getDescricao() + "(z = "+ this.getZ()+")" +"\nlado: " + this.getLado() + "\narea: " + this.calculaArea() + "\nvolume: " + this.calculaVolume();
        }
    }
}
