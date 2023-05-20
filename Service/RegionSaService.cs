public class RegionSaService : IRegionSaService
{
    //Inyeccion de dependencias.
    Context context;
    public RegionSaService(Context DbContext) => context = DbContext;

    //CRUD
    //create
    public async Task Create(Region_Sale newRsales)
    {
        await context.AddAsync(newRsales);
        await context.SaveChangesAsync();
    }
    //Read
    public IEnumerable<Region_Sale> Read() => context.Region_Sales;
    //update
    public async Task Update(Guid id, Region_Sale UpRSales)
    {
        var test = context.Region_Sales.Find(id);
        if (test != null)
        {
            test.NumSales = UpRSales.NumSales;
            // context.Update(Genere);
            await context.SaveChangesAsync();
        }
    }

    //Delelte

    public async Task Delete(Guid id)
    {
        var test = context.Region_Sales.Find(id);
        if (test != null)
        {
            context.Remove(test);
            await context.SaveChangesAsync();
        }
    }

   
}

public interface IRegionSaService
{
    Task Create(Region_Sale newPlatform);
    IEnumerable<Region_Sale> Read();
    Task Update(Guid id, Region_Sale upPlatform);
    Task Delete(Guid id);

}