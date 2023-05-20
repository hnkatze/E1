public class RegionService: IRegionService{
//Inyeccion de dependencias.
Context context;
public RegionService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( Region newRegion ){
    await context.AddAsync(newRegion);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<Region> Read() => context.Regions;
//update
public async Task Update(Guid id, Region UpRegion){
    var test = context.Regions.Find(id);
    if(test != null){
       test.RegionName = UpRegion.RegionName;
        // context.Update(Genere);
    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var test = context.Regions.Find(id);
    if(test!= null)
    {
        context.Remove(test);
        await context.SaveChangesAsync();}}
    
}

public interface IRegionService
{
    Task Create(Region newRegion);
    IEnumerable<Region> Read();
    Task Update(Guid id, Region upRegion);
    Task Delete(Guid id);

}