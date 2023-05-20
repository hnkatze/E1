

using System.ComponentModel.DataAnnotations;

public class Plataform{
[Key]
public Guid PlataformId{get;set;} = Guid.NewGuid();

[Required]
public String PlatformName{get;set;}

}