
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Region_Sales{
[ForeignKey ("RegionId")]
public Guid RegionId{get;set;}

[ForeignKey ("Game_Platform")]
public Guid GamePId{get;set;}
[Required]
public int Num_Sales {get;set;}


public virtual Region region{get;set;}
public virtual Game_Platform game_platform{get;set;}


}