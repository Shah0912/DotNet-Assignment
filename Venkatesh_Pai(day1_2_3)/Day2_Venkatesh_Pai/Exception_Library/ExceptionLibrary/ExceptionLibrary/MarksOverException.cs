using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLibrary
{
    public class MarksOverException:Exception
    {
        public MarksOverException(string msg):base(msg)
        {

        }
    }
}
