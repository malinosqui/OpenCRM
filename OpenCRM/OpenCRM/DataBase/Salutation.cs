//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCRM.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salutation
    {
        public Salutation()
        {
            this.Contact = new HashSet<Contact>();
        }
    
        public int SalutationId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
