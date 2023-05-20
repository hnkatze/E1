public class PlatformService : IPlatformService
{
    //Inyeccion de dependencias.
    Context context;
    public PlatformService(Context DbContext) => context = DbContext;

    //CRUD
    //create
    public async Task Create(Platform newPlatform)
    {
        await context.AddAsync(newPlatform);
        await context.SaveChangesAsync();
    }
    //Read
    public IEnumerable<Platform> Read() => context.Platforms;
    //update
    public async Task Update(Guid id, Platform UpPlatform)
    {
        var test = context.Platforms.Find(id);
        if (test != null)
        {
            test.PlatformName = UpPlatform.PlatformName;
            // context.Update(Genere);
            await context.SaveChangesAsync();
        }
    }

    //Delelte

    public async Task Delete(Guid id)
    {
        var test = context.Platforms.Find(id);
        if (test != null)
        {
            context.Remove(test);
            await context.SaveChangesAsync();
        }
    }

 
   
}

public interface IPlatformService
{
    Task Create(Platform newPlatform);
    IEnumerable<Platform> Read();
    Task Update(Guid id, Platform upPlatform);
    Task Delete(Guid id);

}