//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpresaXwebService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdemDeServico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdemDeServico()
        {
            this.Realizado = new HashSet<Realizado>();
        }
    
        public int id { get; set; }
        public Nullable<int> pecaId { get; set; }
        public Nullable<int> usuarioId { get; set; }
        public Nullable<int> clienteId { get; set; }
        public Nullable<int> usinagemId { get; set; }
        public Nullable<decimal> valorTotal { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Peca Peca { get; set; }
        public virtual Usinagem Usinagem { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Realizado> Realizado { get; set; }
    }
}