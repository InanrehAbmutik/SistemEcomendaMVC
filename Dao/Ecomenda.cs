namespace Dao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ecomenda")]
    public partial class Ecomenda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ecomenda()
        {
            ProdutoEncomendas = new HashSet<ProdutoEncomenda>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Descricao { get; set; }

        public int? IdEstado { get; set; }

        public DateTime? DataRegisto { get; set; }

        public int? IdCliente { get; set; }

        public bool? Estado { get; set; }

        public int? IdSatisfacao { get; set; }

        public decimal? Total { get; set; }

        public decimal? Valor { get; set; }

        public decimal? Troco { get; set; }

        public int? IdForma { get; set; }

        [StringLength(50)]
        public string Localizacao { get; set; }

        public virtual EstadoEncomenda EstadoEncomenda { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual SatisfacaoEncomenda SatisfacaoEncomenda { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoEncomenda> ProdutoEncomendas { get; set; }
    }
}
