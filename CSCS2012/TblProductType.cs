//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSCS2012
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblProductType
    {
        public TblProductType()
        {
            this.TblProducts = new HashSet<TblProduct>();
        }
    
        public int ProductType { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}