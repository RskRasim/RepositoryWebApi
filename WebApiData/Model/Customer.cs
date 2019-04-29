namespace WebApiData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public int Id { get; set; }

        [StringLength(45)]
        public string Name { get; set; }

        [StringLength(45)]
        public string Surname { get; set; }

        [StringLength(45)]
        public string CompanyName { get; set; }

        public string Taxnumber { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
