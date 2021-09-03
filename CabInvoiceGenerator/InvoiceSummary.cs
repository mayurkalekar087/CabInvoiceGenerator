using System;
using System.Collections.Generic;


namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        //Variables
        private int numberOfRides;
        private double totalFare;
        private double averageFare;
        //parameter Constructor For Settling Data.
        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            //Setting data.
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }
        /// <summary>
        /// overriding Equals Methods.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;
            InvoiceSummary inputObject = (InvoiceSummary)obj;
            return this.numberOfRides == inputObject.numberOfRides && this.totalFare == inputObject.totalFare && this.averageFare == inputObject.averageFare;
        }
        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}