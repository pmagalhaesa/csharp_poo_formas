using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica3_Application
{
    abstract class FormaTridimensional : Forma
    {
        private double z;

        public double getZ()
        {
            return this.z;
        }

        public void setZ(double z)
        {
            this.z = z;
        }
    }
}
