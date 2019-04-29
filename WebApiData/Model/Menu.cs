namespace WebApiData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Menu
    {
        public int Id { get; set; }

        [StringLength(35)]
        public string Name { get; set; }

        [StringLength(3)]
        public string language { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(45)]
        public string Link { get; set; }
    }
}
