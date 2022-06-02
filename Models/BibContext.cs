
using Microsoft.EntityFrameworkCore;
namespace lab11.Models;
public class BibContext: DbContext
{
    public BibContext()
    {
    }

    public BibContext(DbContextOptions<BibContext> options)
    : base(options)
    {
    }
    public DbSet<Livro> Livros {get;set;} = null!;
    public DbSet<Autor> Autores {get;set;} = null!;
    public DbSet<Emprestimo> Emprestimos {get;set;} = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>(entityBuilder => {
            entityBuilder.Property(e => e.titulo)
                .HasMaxLength(30);
        });
        modelBuilder.Entity<Autor>(entityBuilder => {
            entityBuilder.Property(e => e.primeiroNome)
                .HasMaxLength(30);
            entityBuilder.Property(e => e.ultimoNome)
                .HasMaxLength(50);
        });
    }
}