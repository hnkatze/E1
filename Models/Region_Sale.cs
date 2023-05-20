
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Region_Sale{ 

    [Key]
    public Guid RegionSId{get;set;} = Guid.NewGuid();
//     [NotMapped]
// [ForeignKey ("RegionId")]
// public Guid RegionId{get;set;}
// [NotMapped]
// [ForeignKey ("Game_Platform")]
// public Guid GamePId{get;set;}
[Required]
public int NumSales {get;set;}


// public virtual Region region{get;set;}
// public virtual Game_Platform game_platform{get;set;}


}