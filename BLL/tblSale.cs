//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSale
    {
        public int SalesId { get; set; }
        public Nullable<int> SalesInvoiceId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<System.DateTime> SalesDate { get; set; }
        public Nullable<decimal> Tax { get; set; }
    
        public virtual tblProduct tblProduct { get; set; }
        public virtual tblSalesInvoice tblSalesInvoice { get; set; }
    }
}
