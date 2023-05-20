
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Game{
[Key]
public Guid GameId{get;set;}
[Required]
public String GameName{get;set;}
// [NotMapped]
// [ForeignKey("Genere")]
// public Guid GenereId{get;set;}

// public virtual Genere genere{get;set;}
}

