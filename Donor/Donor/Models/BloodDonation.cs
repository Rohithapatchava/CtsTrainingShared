//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Donor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BloodDonation
    {
        public int Id { get; set; }
        public string BloodGroup { get; set; }
        public string EmailId { get; set; }
        public string DonatedAlready { get; set; }
        public string State { get; set; }
        public string City { get; set; }
    }
}
