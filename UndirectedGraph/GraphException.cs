using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    //Класс исключений
    class GraphException : Exception
    {
        public GraphException() : base() { }

        public GraphException(string message) : base(message) { }

        public GraphException(string message, Exception inner) : base(message, inner) { }

        protected GraphException(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }

        public override string ToString()
        {
            return "При работе с графом возникла исключительная ситуация";
        }
    }
}
