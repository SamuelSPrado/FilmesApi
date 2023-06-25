using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        if (!string.IsNullOrEmpty(filme.Titulo))
        {
            filmes.Add(filme);
            Console.WriteLine("Título: " + filme.Titulo);
            Console.WriteLine("Gênero: " + filme.Genero);
            Console.WriteLine("Diretor : " + filme.Diretor);
            Console.WriteLine("Ano de lançamento: " + filme.Ano);
            Console.WriteLine("Duração: " + filme.Duracao + " minutos");
        }
        
    }
}
