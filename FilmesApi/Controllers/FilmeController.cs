using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 1000;

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        Console.WriteLine("Título: " + filme.Titulo);
        Console.WriteLine("Gênero: " + filme.Genero);
        Console.WriteLine("Diretor : " + filme.Diretor);
        Console.WriteLine("Ano de lançamento: " + filme.Ano);
        Console.WriteLine("Duração: " + filme.Duracao + " minutos");

    }
    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes()
    {
        return filmes;
    }

    [HttpGet("{id}")]
    public void RecuperaFilmesId(int id)
    {
        filmes.FirstOrDefault(filme => filme.Id == id);
    }
}
