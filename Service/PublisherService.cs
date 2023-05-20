public class PublisherService: IPublisherService{
//Inyeccion de dependencias.
Context context;
public PublisherService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( Publisher newPublisher ){
    await context.AddAsync(newPublisher);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<Publisher> Read() => context.Publishers;
//update
public async Task Update(Guid id, Publisher UpPublisher){
    var upge = context.Publishers.Find(id);
    if(upge != null){
       upge.PublisherName = UpPublisher.PublisherName;
        // context.Update(Genere);
    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var test = context.Publishers.Find(id);
    if(test!= null)
    {
        context.Remove(test);
        await context.SaveChangesAsync();}}
    
}

public interface IPublisherService
{
     Task Create(Publisher newPublisher);
    IEnumerable<Publisher> Read();
    Task Update(Guid id, Publisher upPublisher);
    Task Delete(Guid id);
}

