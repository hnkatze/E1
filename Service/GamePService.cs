public class GamePService : IGamePService
{
    //Inyeccion de dependencias.
    Context context;
    public GamePService(Context DbContext) => context = DbContext;

    //CRUD
    //create
    public async Task Create(Game_Platform newPlatform)
    {
        await context.AddAsync(newPlatform);
        await context.SaveChangesAsync();
    }
    //Read
    public IEnumerable<Game_Platform> Read() => context.Game_Platforms;
    //update
    public async Task Update(Guid id, Game_Platform UpPlatform)
    {
        var test = context.Game_Platforms.Find(id);
        if (test != null)
        {
            test.Releaseyear = UpPlatform.Releaseyear;
            await context.SaveChangesAsync();
        }
    }

    //Delelte

    public async Task Delete(Guid id)
    {
        var test = context.Game_Platforms.Find(id);
        if (test != null)
        {
            context.Remove(test);
            await context.SaveChangesAsync();
        }
    }

}

public interface IGamePService
{
    Task Create(Game_Platform newPlatform);
    IEnumerable<Game_Platform> Read();
    Task Update(Guid id, Game_Platform upPlatform);
    Task Delete(Guid id);

}