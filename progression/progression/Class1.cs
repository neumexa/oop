using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progression
{
    abstract class Progression
    {
        public abstract float GetElement(int k);
    }

    class ArithmeticProgression : Progression
    {
        private float a;
        private float d;

        public ArithmeticProgression(float a, float d)
        {
            this.a = a;
            this.d = d;
        }

        public override float GetElement(int k)
        {
            return a + (k - 1) * d;
        }
    }

    class GeometricProgression : Progression
    {
        private float b;
        private float q;

        public GeometricProgression(float b, float q)
        {
            this.b = b;
            this.q = q;
        }

        public override float GetElement(int k)
        {
            return b * (float)Math.Pow(q, k - 1);
        }
    }
}