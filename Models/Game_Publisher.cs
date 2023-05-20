

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Game_Plublisher{

[Key]
public Guid GamePuid{get;set;} = Guid.NewGuid();

[ForeignKey("Game")]
public Guid GameId{get;set;}

[ForeignKey("Publisher")]
public Guid PublisherId{get;set;}


public virtual Publisher publisher{get;set;}
public virtual Game game{get;set;}
}