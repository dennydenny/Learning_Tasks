using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_XML
{
    class EmptyClientsListException : Exception
    {
        
        public EmptyClientsListException()
    {
    }

    public EmptyClientsListException(string message)
        : base(message)
    {
    }

    public EmptyClientsListException(string message, Exception inner)
        : base(message, inner)
    {
    }
    
    }
}
