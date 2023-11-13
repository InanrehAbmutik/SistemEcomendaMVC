namespace Dao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produto")]
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            ProdutoEncomendas = new HashSet<ProdutoEncomenda>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Descricao { get; set; }

        public int? IdCategoria { get; set; }

        public string ImgCaminho { get; set; }

        public bool? Estado { get; set; }

        public bool? Disponivel { get; set; }

        public DateTime? DataRegisto { get; set; }

        public decimal? Preco { get; set; }

        public virtual Categoria Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoEncomenda> ProdutoEncomendas { get; set; }
    }
}
