//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P2_Programacao_Internet
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENDAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDAS()
        {
            this.REG_VENDAS = new HashSet<REG_VENDAS>();
        }
    
        public int ID { get; set; }
        public int ID_CLIENTE { get; set; }
        public string STATUS { get; set; }
        public Nullable<double> VALOR_TOTAL { get; set; }
        public Nullable<System.DateTime> DATA { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REG_VENDAS> REG_VENDAS { get; set; }
    }
}