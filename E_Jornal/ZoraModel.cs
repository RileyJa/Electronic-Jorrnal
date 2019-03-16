namespace E_Jornal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZoraModel : DbContext
    {
        public ZoraModel()
            : base("name=ZoraModel")
        {
        }

        public virtual DbSet<Group_1> Group_1 { get; set; }
        public virtual DbSet<Lectures> Lectures { get; set; }
        public virtual DbSet<Professors> Professors { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group_1>()
                .HasMany(e => e.Students)
                .WithOptional(e => e.Group_1)
                .HasForeignKey(e => e.Group_Id);

            modelBuilder.Entity<Professors>()
                .HasMany(e => e.Subject)
                .WithRequired(e => e.Professors)
                .HasForeignKey(e => e.Professor_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Students>()
                .HasMany(e => e.Lectures)
                .WithRequired(e => e.Students)
                .HasForeignKey(e => e.Studen_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Lectures)
                .WithRequired(e => e.Subject)
                .HasForeignKey(e => e.Subject_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
