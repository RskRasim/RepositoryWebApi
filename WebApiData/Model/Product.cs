namespace WebApiData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
        }

        public int Id { get; set; }

        [Required]
        public string ProductCode { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string BarcodeCode { get; set; }

        public string BarcodeCode2 { get; set; }

        public int? ShelfNumber { get; set; }

        public int? Pieces { get; set; }

        public int? MaxPieces { get; set; }

        public int? MinPieces { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int? TaxRate { get; set; }

        public int? CompanyId { get; set; }

        public int? StoreId { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InsertionDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Total { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalProductValue { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public virtual Store Store { get; set; }
    }
}
