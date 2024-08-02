using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.Revisao.Aula02.Exemplo01.Models
{
    public class Planeta
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Nome { get; set; }

        //Renderizar um campo do tipo date
        [DataType(DataType.Date), Display(Name = "Data de Descoberta")]
        public DateTime DataDescoberta { get; set; }

        [Display(Name = "Habitável")]
        public bool Habitavel { get; set; }

        public TipoPlaneta Tipo { get; set; }

        public string Atmosfera { get; set; }

        [Display(Name = "Galáxia")]
        public string Galaxia { get; set; } //Via Láctea, Andrômeda

        [Display(Name = "Tempo de Rotação")]
        public int TempoRotacao { get; set; }
    }

    public enum TipoPlaneta
    {
        Terrestre, Gasoso
    }
}
