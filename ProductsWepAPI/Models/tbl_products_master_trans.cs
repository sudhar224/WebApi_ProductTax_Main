namespace ProductsWepAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_products_master_trans
    {
        public int id { get; set; }

        public int? product_code { get; set; }

        [StringLength(100)]
        public string product_name { get; set; }

        public int? quantity { get; set; }

        public double? rate { get; set; }

        public double? tax_amount { get; set; }

        public double? tax_percentage { get; set; }

        public double? gross_total { get; set; }
    }
}
