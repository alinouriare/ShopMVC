//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyShop.Models
{
    using System.ComponentModel.DataAnnotations;
    using System;
    using System.Collections.Generic;
    
    [MetadataType(typeof(StateSiteMetadata))]
    public partial class StateSite
    {
        public int StateID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> Count { get; set; }
    }
}
