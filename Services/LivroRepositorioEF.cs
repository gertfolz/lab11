using lab11.Models;
namespace lab11.Services;
using Microsoft.EntityFrameworkCore;

public class LivroRepositorioEF : ILivroRepositorio
{
    private readonly BibContext _contexto;

    public LivroRepositorioEF(BibContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Livro> ConsultarAsync(int id)
    {
        var Livro = await _contexto.Livros.FindAsync(id);
        if (Livro is null)
        {
            throw new LivroNaoEncontradoException(id);
        }
        return Livro;
    }

    public async Task<IEnumerable<Livro>> ConsultarTodosAsync()
    {
        return await _contexto.Livros.ToListAsync();
    }
}