//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semana13_2_AJAX_Cine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cine()
        {
            this.CinePelicula = new HashSet<CinePelicula>();
            this.Sala = new HashSet<Sala>();
        }
    
        public int CodCine { get; set; }
        public string NombreCine { get; set; }
        public string Direccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CinePelicula> CinePelicula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sala> Sala { get; set; }
    }
}
