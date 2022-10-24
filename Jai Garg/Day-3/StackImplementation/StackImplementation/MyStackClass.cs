using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class MyStackClass
    {
        private ArrayList elements = new ArrayList();
        public bool IsEmpty
        {
            get
            {
                return (elements.Count == 0);
            }
        }
        public object Push(object element)
        {
            elements.Insert(0, element);
            return elements[0];
        }
        public object Pop()
        {
            object top = Top();
            elements.RemoveAt(0);
            return top;
        }
        public object Top()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is Empty");
            return elements[0];
        }
    }

}
