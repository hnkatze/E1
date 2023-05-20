
public class GenereService: IGenereService{
//Inyeccion de dependencias.
Context context;
public GenereService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( Genere newGenere ){
    await context.AddAsync(newGenere);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<Genere> Read() => context.Generes;
//update
public async Task Update(Guid id, Genere UpGenere){
    var upge = context.Generes.Find(id);
    if(upge != null){
       upge.GenereName = UpGenere.GenereName;
        // context.Update(Genere);
    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var gener = context.Generes.Find(id);
    if(gener!= null)
    {
        context.Remove(gener);
        await context.SaveChangesAsync();}}
    
}

public interface IGenereService
{
    Task Create(Genere newGenere);
    IEnumerable<Genere> Read();
    Task Update(Guid id, Genere upGenere);
    Task Delete(Guid id);

}