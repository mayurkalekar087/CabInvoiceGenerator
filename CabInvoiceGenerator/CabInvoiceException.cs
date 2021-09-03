using System;
using System.Collections.Generic;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Class For Exception Custom Handeling
    /// </summary>
    class CabInvoiceException : Exception
    {
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }

        ExceptionType type;
        /// <summary>
        /// parameter Constructor For Settling Type And Throwing Exception.
        /// </summary>
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}