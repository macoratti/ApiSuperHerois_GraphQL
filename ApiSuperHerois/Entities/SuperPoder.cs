using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiSuperHerois.Entities;

public class SuperPoder
{
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Infome o super poder")]
    public string? Super_Poder { get; set; }
    public string? Descricao { get; set; }

    [ForeignKey("SuperHeroiId")]
    public Guid SuperHeroiId { get; set; }
    public SuperHeroi? SuperHeroi { get; set; }
}
