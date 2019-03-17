//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vtdi_Gatelog
{
    using System;
    using System.Collections.Generic;
    
    public partial class GateInTable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlateNum { get; set; }
        public Nullable<System.DateTime> DateTimeIn { get; set; }
        public Nullable<System.DateTime> DateTimeOut { get; set; }
        public Nullable<int> UserID { get; set; }
        public int ItemsToDeclareID { get; set; }
        public int PurposeID { get; set; }
        public int VehicletypesID { get; set; }
    
        public virtual ItemstoDeclare ItemstoDeclare { get; set; }
        public virtual Purpose Purpose { get; set; }
        public virtual User User { get; set; }
        public virtual Vehicletype Vehicletype { get; set; }
    }
}