//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adverts
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime Created { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int MessageType { get; set; }
        public System.Data.Spatial.DbGeography Position { get; set; }
    }
}
