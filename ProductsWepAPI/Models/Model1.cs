using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProductsWepAPI.Models
{
	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=Model1")
		{
		}

		public virtual DbSet<tbl_products_master_trans> tbl_products_master_trans { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<tbl_products_master_trans>()
				.Property(e => e.product_name)
				.IsUnicode(false);
		}
	}
}
