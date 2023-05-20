

using System.ComponentModel.DataAnnotations;

public  class Region {

[Key]
public Guid RegionId {get;set;} = Guid.NewGuid();

[Required]
public String RegionName {get; set;}

}