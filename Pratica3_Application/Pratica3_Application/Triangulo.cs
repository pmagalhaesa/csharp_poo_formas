using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    class Triangulo : FormaBidimensional, IForma
    {
        private double minhaBase;
        private double altura;

        public Triangulo(double x, double y, double minhaBase, double altura)
        {
            this.init(x, y, minhaBase, altura);
        }
        public Triangulo(double x, double y, double minhaBase, double altura, string nome)
        {
            this.init(x, y, minhaBase, altura);
            this.setNome(nome);
        }

        private void init(double x, double y, double minhaBase, double altura)
        {
             if (minhaBase == 0 || altura == 0)
            {
                throw new NumeroZeroException();
            }
            else if (minhaBase < 0 || altura < 0)
            {
                throw new NumeroNegativoException();
            }
            this.minhaBase = minhaBase;
            this.altura = altura;
            
            this.setX(x);
            this.setY(y);
        }

        
        public double getMinhaBase()
        {
            return this.minhaBase;
        }

        public void setMinhaBase(double minhaBase)
        {
            this.minhaBase = minhaBase;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double calculaArea()
        {
            return (this.minhaBase * this.altura) / 2;
        }

        public override string getDescricao()
        {
            return "Triangulo "+ base.getDescricao()+"\nbase: " + this.getMinhaBase() + "\naltura: " + this.getAltura() + "\narea: " + this.calculaArea();
  
        }
    }
}
