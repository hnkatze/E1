
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Game_Platform{

[Key]
public Guid GamePId{get;set;} = Guid.NewGuid();
[Required]
public  int Releaseyear{get; set;}
// [NotMapped]
// [ForeignKey("Game_Plublisher")]
// public Guid GamePuId{get;set;}
// [NotMapped]
// [ForeignKey("Platform")]
// public Guid PlatformId{get;set;}

//public virtual Game_Plublisher game_publisher{get;set;}
//public virtual Platform plataform {get;set;}
}