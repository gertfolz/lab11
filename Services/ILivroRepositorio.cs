namespace lab11.Services;
using lab11.Models;

public interface ILivroRepositorio
{
    Task<IEnumerable<Livro>> ConsultarTodosAsync();
    Task<Livro> ConsultarAsync(int id);
}