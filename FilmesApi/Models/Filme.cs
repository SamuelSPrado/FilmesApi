using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace FilmesApi.Models;

public class Filme
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O título deve conter de 3 à 50 caracteres!")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres!")]
    public string Genero { get; set; }

    [Required, StringLength(70, MinimumLength = 2, ErrorMessage = "É necessário incluir o nome do Diretor")]
    public string Diretor { get; set; }

    [Required, Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos!")]
    public int Duracao { get; set; }

    [Required(ErrorMessage ="Necessário informar o ano de lançamento")]
    public int Ano { get; set; }

}
