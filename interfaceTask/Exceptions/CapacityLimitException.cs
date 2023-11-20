using interfaceTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTask.Exceptions
{
    public class CapacityLimitException :Exception
    {

        public CapacityLimitException(string message) : base(message) 
        {
            
        }
    }
}



