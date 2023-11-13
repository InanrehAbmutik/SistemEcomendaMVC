namespace Dao
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Ecomendas = new HashSet<Ecomenda>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Senha { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefone { get; set; }

        public bool? Cliente { get; set; }

        public bool? Funcionario { get; set; }

        public bool? Estado { get; set; }

        public DateTime? DataRegisto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ecomenda> Ecomendas { get; set; }
    }
}
