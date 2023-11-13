namespace Dao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProdutoEncomenda")]
    public partial class ProdutoEncomenda
    {
        public int Id { get; set; }

        public int? IdProduto { get; set; }

        public int? IdEncomenda { get; set; }

        public int? Qtdade { get; set; }

        public decimal? Preco { get; set; }

        public virtual Ecomenda Ecomenda { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
