using Microsoft.AspNetCore.Mvc;
using lab11.Models;
using lab11.Services;

namespace lab11.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogoController : ControllerBase
{


    private readonly ILogger<CatalogoController> _logger;
    private readonly ILivroRepositorio _livrosRepositorio;
    public CatalogoController(ILogger<CatalogoController> logger, ILivroRepositorio livrosRepositorio)
    {
        _logger = logger;
        _livrosRepositorio = livrosRepositorio;
    }

    //GET .../catalogo
    [HttpGet]
    public Task<IEnumerable<Livro>> GetTodos()
    {
        return _livrosRepositorio.ConsultarTodosAsync();
    }

    //GET .../catalogo/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Livro>> GetPorId(int id)
    {
        try
        {
            var livro = await _livrosRepositorio.ConsultarAsync(id);
            return livro;
        }
        catch (LivroNaoEncontradoException)
        {
            return NotFound();
        }
    }
}
