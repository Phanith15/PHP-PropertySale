//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Occupancy
    {
        public int OccupancyNumber { get; set; }
        public string EmployeeIDFK { get; set; }
        public string CustomerIDFK { get; set; }
        public Nullable<System.DateTime> DateOccupied { get; set; }
        public string RoomIDFK { get; set; }
        public Nullable<double> RateApplied { get; set; }
        public Nullable<int> PhoneCharge { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Room Room { get; set; }
    }
}
