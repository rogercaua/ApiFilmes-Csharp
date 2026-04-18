using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Models;

public class Filme
{
    public int id { get; set;}
    [Required(ErrorMessage ="O Título é obrigatorio.")]
    public string ?Titulo { get; set; }

    [Required(ErrorMessage ="O genero é obrigatorio.")]
    [MaxLength(30, ErrorMessage ="o tamanho maximo é 30")]
    public string ?Genero { get; set; }

    [Required(ErrorMessage = "A duracao é obrigatoria")]
    [Range(70, 600, ErrorMessage = "A duracao deve ser entre 70 e 600 minutos.")]
    public int Duracao { get; set; }

}