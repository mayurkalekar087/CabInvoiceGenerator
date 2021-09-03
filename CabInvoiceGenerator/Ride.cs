using System;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Ride Class To Set Data For Particular Ride
    /// </summary>
    public class Ride
    {
        //Variables.
        public double distance;
        public int time;
        /// <summary>
        /// Parameter Constructor Settling Data.
        /// </summary>
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}