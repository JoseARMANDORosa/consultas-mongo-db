using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller {
    [HttpGet("baño")]
    public IActionResult Baño(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gte(X => X.Baños, 3);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    } 

    [HttpGet("metrosterreno")]
    public IActionResult MetrosTerreno(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gte(X => X.MetrosTerreno, 657);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    } 

    [HttpGet("metrosconstruccion")]
    public IActionResult MetrosConstruccion(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gte(X => X.MetrosConstruccion, 551);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    } 

[HttpGet("pisos")]
    public IActionResult Pisos(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gte(X => X.Pisos, 1);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    } 
    [HttpGet("costo")]
    public IActionResult Costo(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gte(X => X.Costo, 46149);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    } 

}