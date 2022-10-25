using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLibrary
{
    public class MarksOverException :Exception
    {
        public MarksOverException()
        {
        }
        public MarksOverException(string message) : base(message)
        {
        }
       
    }
}
