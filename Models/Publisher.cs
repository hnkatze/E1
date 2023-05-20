

using System.ComponentModel.DataAnnotations;

public class Publisher{
[Key]
public Guid PublisherId{get;set;} = Guid.NewGuid();

[Required]
public String PublisherName{get;set;}



}