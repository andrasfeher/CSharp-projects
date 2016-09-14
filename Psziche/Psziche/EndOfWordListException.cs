using System;
using System.Collections.Generic;
using System.Text;

namespace Psziche
{
    class EndOfWordListException : System.ApplicationException
    {
        public EndOfWordListException() {}
        public EndOfWordListException(string message) {}
        public EndOfWordListException(string message, System.Exception inner) {}
     
        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected EndOfWordListException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) {}
        }
}
