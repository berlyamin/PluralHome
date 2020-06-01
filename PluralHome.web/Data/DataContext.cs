using Microsoft.EntityFrameworkCore;
using PluralHome.Data.Entities;
using PluralHome.web.Data.Entities;
using PluralHome.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralHome.web.Data
{
    public class DataContext :DbContext
    {
        private object owners;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet <Owner>  Owners{ get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Historyproduct> Historyproducts { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Producttype> Producttypes { get; set; }
        public DbSet<SupplierType> SupplierTypes { get; set; }
        internal object Owner { get => owners; set => owners = value; }
        public DbSet<PluralHome.web.Data.Entities.Owner> Owners { get; set; }
    }
}
