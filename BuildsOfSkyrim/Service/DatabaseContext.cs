namespace BuildsOfSkyrim
{
    using BuildsOfSkyrim.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DatabaseContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BuildsOfSkyrim.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public DatabaseContext()
            : base("name=BuildsOfSkyrim_Local.mdf")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Build> Builds { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<PerkTree> PerkTrees { get; set; }
        public virtual DbSet<Perk> Perks { get; set; }
        public virtual DbSet<CharacterTrait> CharacterTraits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Skill>()
                .HasRequired(s => s.PerksAvailable)
                .WithRequiredDependent(p => p.Skill);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}