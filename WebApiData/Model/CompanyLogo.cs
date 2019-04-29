namespace WebApiData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CompanyLogo
    {
        public int Id { get; set; }

        public string Folder { get; set; }

        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}
