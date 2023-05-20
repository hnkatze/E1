


using System.ComponentModel.DataAnnotations;

public class Genere{

[Key]
public Guid GenereId{get;set;} = Guid.NewGuid();

[Required]
public String GenereName{get;set;}



public virtual Game game{get;set;}

}