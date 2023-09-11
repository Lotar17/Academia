namespace EntitiesEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            modulos_usuarios = new HashSet<modulos_usuarios>();
        }

        [Key]
        public int id_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_usuario { get; set; }

        [Required]
        [StringLength(64)]
        public string clave { get; set; }

        public bool habilitado { get; set; }

        public bool? cambia_clave { get; set; }

        public int? id_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modulos_usuarios> modulos_usuarios { get; set; }

        public virtual personas personas { get; set; }
    }
}
