namespace IhopNet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        [Key]
        public short Category_ID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
