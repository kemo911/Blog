namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class contact
    {
        public int id { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [StringLength(50)]
        public string name { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [StringLength(500)]
        public string message { get; set; }
    }
}
