//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int paymentID { get; set; }
        public string transaction_info { get; set; }
        public Nullable<int> paymentType { get; set; }
        public string error_text { get; set; }
        public string orderCode { get; set; }
        public Nullable<decimal> price { get; set; }
        public string currency { get; set; }
        public Nullable<int> quantity { get; set; }
        public string order_desc { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<decimal> discount { get; set; }
        public Nullable<decimal> fee_shipping { get; set; }
        public Nullable<int> status { get; set; }
    }
}