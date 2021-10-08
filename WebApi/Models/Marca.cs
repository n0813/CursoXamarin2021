namespace WebApiXamarin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Marca")]
    public partial class Marca
    {
        [Key]
        public int idMarca { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        public bool? habilitado { get; set; }
    }
}
