using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
public class InController : Controller { 
[HttpGet("renta-venta")]
    public IActionResult RentaVenta(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Operacion, new[] { "Renta", "Venta" });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    } 
    [HttpGet("agentes")]
    public IActionResult Agente(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.In(x => x.NombreAgente, new[] { "Ana Torres", "Carlos Garcia"});
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    } 
    [HttpGet("tipos")]
    public IActionResult Tipo(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Tipo, new[] { "Terreno", "Casa" });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }
    [HttpGet("agencias")]
    public IActionResult Agencia(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Agencia, new[] { "Torres Realty", "Inmobiliar ia Pérez" });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }
    [HttpGet("fechaspublicacion")]
    public IActionResult FechaPublicacion(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.In(x => x.FechaPublicacion, new[] { "2025-01-10", "2025-01-30" });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }
  
}