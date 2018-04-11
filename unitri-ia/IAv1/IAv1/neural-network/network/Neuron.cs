using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IAv1.neural_network
{
    class Neuron
    {

        private Double x1;
        private Double x2;
        private Double x3;
        private Double x4;

        private Double expectedOut;

        private Double deltaw1;
        private Double deltaw2;
        private Double deltaw3;
        private Double deltaw4;

        public Neuron(double x1, double x2, double x3, double x4, double y)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.expectedOut = y;
        }

        public double getX1()
        {
            return x1;
        }

        public double getX2()
        {
            return x2;
        }

        public double getX3()
        {
            return x3;
        }

        public double getX4()
        {
            return x4;
        }

        public double getExpectedOut()
        {
            return expectedOut;
        }

        public double getDeltaw1()
        {
            return deltaw1;
        }

        public void setDeltaw1(double deltaw1)
        {
            this.deltaw1 = deltaw1;
        }

        public double getDeltaw2()
        {
            return deltaw2;
        }

        public void setDeltaw2(double deltaw2)
        {
            this.deltaw2 = deltaw2;
        }

        public double getDeltaw3()
        {
            return deltaw3;
        }

        public void setDeltaw3(double deltaw3)
        {
            this.deltaw3 = deltaw3;
        }

        public double getDeltaw4()
        {
            return deltaw4;
        }

        public void setDeltaw4(double deltaw4)
        {
            this.deltaw4 = deltaw4;
        }

        public String toString()
        {
            return "Neuron{" +
                    "x1=" + x1 +
                    ", x2=" + x2 +
                    ", x3=" + x3 +
                    ", x4=" + x4 +
                    ", expectedOut=" + expectedOut +
                    ", deltaw1=" + deltaw1 +
                    ", deltaw2=" + deltaw2 +
                    ", deltaw3=" + deltaw3 +
                    ", deltaw4=" + deltaw4 +
                    '}';
        }
    }
}
