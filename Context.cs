using Microsoft.EntityFrameworkCore;


public class Context:DbContext {
public DbSet<Game_Platform> Game_Platforms{get;set;}
public DbSet<Game_Plublisher> Game_Plublishers{get;set;}
public DbSet<Game> Games {get;set;}
public DbSet<Genere> Generes {get;set;}
public DbSet<Platform> Platforms {get;set;}
public DbSet<Publisher> Publishers {get; set;}
public DbSet<Region_Sale> Region_Sales{get;set;}
public DbSet<Region> Regions {get;set;}

public Context(DbContextOptions<Context> options) : base(options){}

}