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
    
    public partial class client_services
    {
        public int id { get; set; }
        public Nullable<int> client_id { get; set; }
        public Nullable<int> services_id { get; set; }
        public Nullable<decimal> bid_price { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public Nullable<System.DateTime> completion_date { get; set; }
        public Nullable<int> paid { get; set; }
    }
}