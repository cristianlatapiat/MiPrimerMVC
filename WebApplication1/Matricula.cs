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
    
    public partial class Matricula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matricula()
        {
            this.DetalleMatricula = new HashSet<DetalleMatricula>();
        }
    
        public int IIDMATRICULA { get; set; }
        public Nullable<int> IIDPERIODO { get; set; }
        public Nullable<int> IIDGRADO { get; set; }
        public Nullable<int> IIDSECCION { get; set; }
        public Nullable<int> IIDALUMNO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<int> BHABILITADO { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleMatricula> DetalleMatricula { get; set; }
        public virtual Grado Grado { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual Seccion Seccion { get; set; }
    }
}
