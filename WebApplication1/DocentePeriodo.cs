//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocentePeriodo
    {
        public int IIDDOCENTE { get; set; }
        public int IIDPERIODO { get; set; }
        public Nullable<int> BHABILITADO { get; set; }
    
        public virtual Docente Docente { get; set; }
        public virtual Periodo Periodo { get; set; }
    }
}
