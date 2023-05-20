
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Game{
[Key]
public Guid GameId{get;set;}

[ForeignKey("Genere")]
public Guid GenereId{get;set;}

public virtual Genere genere{get;set;}
}
