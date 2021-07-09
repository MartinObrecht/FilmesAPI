using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo título não pode ser vazio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor não pode ser vazio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O tamanho do genêro não pode ser superior a 30")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve estar entre 1 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
