
namespace lab11.Models;

public class Emprestimo
{
    public int id {get; set;}
    public DateTime dataRetirada {get;set;}
    public DateTime dataDevolucao {get;set;}
    public bool entregue {get;set;} = false;

}