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
    
    public partial class Feedback
    {
        public int feedbackID { get; set; }
        public Nullable<int> photoID { get; set; }
        public Nullable<int> userID { get; set; }
        public string guestName { get; set; }
        public string subject { get; set; }
        public Nullable<int> rating { get; set; }
        public string comment { get; set; }
        public string feedbackDate { get; set; }
        public Nullable<int> status { get; set; }
    }
}