//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contributor
    {
        public Contributor()
        {
            this.Projects = new HashSet<Project>();
        }
    
        public int CNID { get; set; }
        public string CNName { get; set; }
        public string CNEmail { get; set; }
        public string CNPassword { get; set; }
        public Nullable<int> CNImage { get; set; }
        public System.DateTime CNCreated { get; set; }
    
        public virtual Image Image { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}