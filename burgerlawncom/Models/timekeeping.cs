//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace burgerlawncom.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class timekeeping
    {
        public int id { get; set; }
        public Nullable<int> client_service_id { get; set; }
        public string time_taken { get; set; }
        public Nullable<System.DateTime> creation_date { get; set; }
    }
}