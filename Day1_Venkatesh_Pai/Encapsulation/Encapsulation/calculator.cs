// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class calculator
    {

        private float res = 0;
        public float val1, val2;
        private float x;
        private float y;

        public calculator(float a, float b)
        {
            this.val1 = a;
            this.val2 = b;
        }

        public float Res
        {
            get
            {
                return this.res;
            }
            set
            {
                this.res = value;
            }
        }


        public void add()
        {
            res = val1 + val2;
        }
        public void sub()
        {
            res = val1 - val2;
        }
        public void mul()
        {
            res = val2 * val2;

        }
        public void div()
        {
            try
            {
                int v1 = (int)val1;
                int v2 = (int)val2;
                res = v1 / v2;
            }

            catch(Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e.Message);
                Console.WriteLine("Second number should not be zero while performing!!");
            }
        }
    }
}
