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
    
    public partial class Realizado
    {
        public int id { get; set; }
        public Nullable<int> OrdemDeServicoId { get; set; }
        public Nullable<int> usinagemId { get; set; }
        public Nullable<decimal> valorTotal { get; set; }
    
        public virtual OrdemDeServico OrdemDeServico { get; set; }
        public virtual Usinagem Usinagem { get; set; }
    }
}
