//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeanerSnow.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public Image()
        {
            this.Organizations = new HashSet<Organization>();
            this.Projects = new HashSet<Project>();
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public int Type { get; set; }
        public string Path { get; set; }
    
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
