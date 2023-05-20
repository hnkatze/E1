using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = "Data Source=localhost,1433; Initial Catalog=VideoJuegos; user ID=SA; Password=C@m1l1t0*; TrustServerCertificate=True";
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// agregamos Context
builder.Services.AddScoped< IGenereService, GenereService>();
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IGamePService,GamePService>();
builder.Services.AddScoped<IGamePuService, GamePuService>();
builder.Services.AddScoped<IPlatformService, PlatformService>();
builder.Services.AddScoped<IPublisherService, PublisherService>();
builder.Services.AddScoped<IRegionSaService, RegionSaService>();
builder.Services.AddScoped<IRegionService, RegionService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
