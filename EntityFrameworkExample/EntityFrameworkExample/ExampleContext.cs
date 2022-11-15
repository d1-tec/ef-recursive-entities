using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class ExampleContext : DbContext
    {
        public DbSet<MyEntity> Entities { get; set; }

        public ExampleContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ExampleContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyEntity>()
                .HasMany(e => e.RecursiveEntities)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("OwnerId");
                    m.MapRightKey("RecursiveId");
                    m.ToTable("RecursiveEntities");
                });
        }
    }
}
