
   
namespace lab11.Services;

public class LivroNaoEncontradoException: Exception
{
    public LivroNaoEncontradoException(int id)
    : base ($"Livro id={id} não encontrado")
    {        
    }
}