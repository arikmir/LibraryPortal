//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryPortal.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckedOutTable
    {
        public int CheckedOutId { get; set; }
        public int ItemId { get; set; }
        public System.DateTime CheckedOutDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public string CheckedOutBy { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
