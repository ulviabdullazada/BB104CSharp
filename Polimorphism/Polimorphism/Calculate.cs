using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Calculate : IAddition, ISubtraction, IDivision, IMultiplication
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
    interface IAddition
    {
        int Add(int num1, int num2);
    }
    interface ISubtraction
    {
        int Subtract(int num1, int num2);
    }
    interface IDivision
    {
        float Divide(float num1, float num2);
    }
    interface IMultiplication
    {
        float Multiply(float num1, float num2);
    }
}
