using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Helpers;

namespace Domain.Model;

public class TechData : ISoftDelete
{
    [Required]
    public string PlantId { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public int Id { get; set; }
    [StringLength(255)]
    public string ItemName { get; set; }
    [StringLength(40)]
    public string ItemUm { get; set; }
    [StringLength(255)]
    public string ItemValue { get; set; }

    public Plant Plant { get; set; }

    #region Implementation of ISoftDelete

    public bool Zap { get; set; }
    public DateTime zapDate { get; set; }
    public string? zapper { get; set; }

    #endregion
}