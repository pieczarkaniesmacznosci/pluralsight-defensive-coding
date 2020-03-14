using System;
using System.Collections.Generic;
using System.Text;

namespace APM.Utilities
{
    [Serializable()]
    public class DiscountNotFoundException :System.Exception
    {
        public DiscountNotFoundException()
        {

        }

        public DiscountNotFoundException(string message) : base(message)
        {

        }

        // useful when we want to throw our exception as a result of a prior exception 
        public DiscountNotFoundException(string message, Exception inner) : base(message, inner)
        {

        }
        // to make exception serializable, 
        protected DiscountNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context): base(info, context)
        {

        }
    }
}
