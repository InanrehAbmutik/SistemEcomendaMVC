namespace Dao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadoEncomenda")]
    public partial class EstadoEncomenda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadoEncomenda()
        {
            Ecomendas = new HashSet<Ecomenda>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Descricao { get; set; }

        public bool? Estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ecomenda> Ecomendas { get; set; }
    }
}
