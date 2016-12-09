using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class Tetraedro : FormaTridimensional, IForma, IFormaTriDimensional
    {
        private double minhaBase;
        private double alturaBase;
        private double alturaTetraedro;

        public Tetraedro(double x, double y, double z, double minhaBase, double alturaBase, double alturaTetraedro, string nome)
        {
            if (minhaBase == 0 || alturaBase == 0 || alturaTetraedro == 0)
            {
                throw new NumeroZeroException();
            }
            else if (minhaBase < 0 || alturaBase < 0 || alturaTetraedro < 0)
            {
                throw new NumeroNegativoException();
            }
            this.minhaBase = minhaBase;
            this.alturaBase = alturaBase;
            this.alturaTetraedro = alturaTetraedro;
            this.setNome(nome);
            this.setX(x);
            this.setY(y);
            this.setZ(z);
        }
        public double getMinhaBase()
        {
            return this.minhaBase;
        }

        public void setMinhaBase(double minhaBase)
        {
            this.minhaBase = minhaBase;
        }

        public double getAlturaBase()
        {
            return this.alturaBase;
        }

        public void setAlturaBase(double alturaBase)
        {
            this.alturaBase = alturaBase;
        }


        public double getAlturaTetraedro()
        {
            return this.alturaTetraedro;
        }

        public void setAlturaTetraedro(double alturaTetraedro)
        {
            this.alturaTetraedro = alturaTetraedro;
        }

        public override string getDescricao()
        {
            return "Tetraedro "  + base.getDescricao() + "(z = " + this.getZ()+")"  +"\nbase: " + this.getMinhaBase() + "\naltura do tetraedro: " + Convert.ToString(this.getAlturaTetraedro()) + "\naltura da base: " + Convert.ToString(this.getAlturaBase()) + "\narea: " + this.calculaArea() + "\nvolume: " + this.calculaVolume();
        }

        public double calculaArea()
        {
            Triangulo tri1 = new Triangulo(this.getX(), this.getY(),this.minhaBase , this.alturaBase);
            double ab = tri1.calculaArea();

            Triangulo tr2 = new Triangulo(this.getX(), this.getY(), this.alturaTetraedro, this.alturaTetraedro);
            double a1 = 4* tr2.calculaArea();

            return a1 + ab;
        }

        public double calculaVolume()
        {
            Triangulo tri1 = new Triangulo(this.getX(), this.getY(), this.getMinhaBase(), this.getAlturaBase());
            double ab = tri1.calculaArea();
            return (1.0 / 3.0) * (ab * this.getAlturaTetraedro());
        }
    }
}
