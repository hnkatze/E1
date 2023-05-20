public class GameService: IGameService{
//Inyeccion de dependencias.
Context context;
public GameService(Context DbContext) => context = DbContext;

//CRUD
//create
public async Task Create( Game newGame ){
    await context.AddAsync(newGame);
    await context.SaveChangesAsync();
}
//Read
public IEnumerable<Game> Read() => context.Games;
//update
public async Task Update(Guid id, Game UpGame){
    var upge = context.Games.Find(id);
    if(upge != null){
       upge.GameName = UpGame.GameName;

    await context.SaveChangesAsync();
}}

//Delelte

public async Task Delete(Guid id)
{
    var gener = context.Games.Find(id);
    if(gener!= null)
    {
        context.Remove(gener);
        await context.SaveChangesAsync();}}
    
}

public interface IGameService
{
    Task Create(Game newGame);
    IEnumerable<Game> Read();
    Task Update(Guid id, Game upGame);
    Task Delete(Guid id);

}