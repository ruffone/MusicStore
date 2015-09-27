using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MusStore.Models
{
    class StoreContext: DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Cart> Carts {get; set;}
        public DbSet<Ord> Ords {get; set;}
        public DbSet<OrdDetail> OrdDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Album>().HasRequired(p => p.Genre).WithMany(b => b.Albums).HasForeignKey(p => p.GenreId);
            //modelBuilder.Entity<Album>().HasMany(m => m.Genre).WithOptional().HasForeignKey(h => h.GenreId);
            //modelBuilder.Entity<Album>().HasRequired(p => p.Artist).WithMany(b => b.Albums).HasForeignKey(p => p.ArtistId);

        }

        public System.Data.Entity.DbSet<MusStore.Models.Artist> Artists { get; set; }
    }
}
