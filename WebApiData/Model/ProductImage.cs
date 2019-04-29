namespace WebApiData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductImage
    {
        public int Id { get; set; }

        public string ImgFolder { get; set; }

        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
