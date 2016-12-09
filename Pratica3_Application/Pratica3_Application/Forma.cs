using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    abstract class Forma
    {
        private double x;
        private double y;
        private string nome;

        public Forma() { }
        public double getX()
        {
            return this.x;
        }

        public void setX(double x)
        {
            this.x = x;
        }

        public double getY()
        {
            return this.y;
        }

        public void setY(double y)
        {
            this.y = y;
        }


        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        // Virtual pois vou usa-la para imprimir oq é comum para todos
        public virtual string getDescricao()
        {
            return "(Nome: " +this.getNome() + ") | (x= " + this.getX() + " y= " + this.getY() + ")";
        }

        public static double calculoDistancia(Forma c1, Forma c2)
        {
            return Math.Sqrt(Math.Pow((c2.getX() - c1.getX()), 2) + Math.Pow((c2.getY() - c1.getY()), 2));
        }

    }
}
