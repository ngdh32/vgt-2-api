using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class VgtDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public DbSet<EFVocablistEntity> Vocablists {get;set;}
    public DbSet<EFVocabEntity> Vocabs {get;set;}
    public DbSet<EFExampleEntity> Examples {get;set;}

    public VgtDbContext (DbContextOptions<VgtDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<EFVocablistEntity>().Property(e => e.Id).HasDefaultValueSql("(uuid())");
        modelBuilder.Entity<EFVocabEntity>().Property(e => e.Id).HasDefaultValueSql("(uuid())");
        modelBuilder.Entity<EFExampleEntity>().Property(e => e.Id).HasDefaultValueSql("(uuid())");

        modelBuilder.Entity<EFVocabEntity>().HasOne<EFVocablistEntity>().WithMany().HasForeignKey(e => e.VocablistId);
        modelBuilder.Entity<EFExampleEntity>().HasOne<EFVocabEntity>().WithMany().HasForeignKey(e => e.VocabId);
    }
}