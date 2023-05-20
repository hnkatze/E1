

using System.ComponentModel.DataAnnotations;

public class Platform{
[Key]
public Guid PlatformId{get;set;} = Guid.NewGuid();

[Required]
public String PlatformName{get;set;}

}