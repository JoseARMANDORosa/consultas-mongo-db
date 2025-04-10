using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/nin")]

public class NinController : Controller {
     [HttpGet("baños")]
    public IActionResult Baños(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Baños, new[] { 1, 2 });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }

    [HttpGet("pisos")]
    public IActionResult Pisos(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Pisos, new[] { 0, 1 });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }

     [HttpGet("nombreagente")]
    public IActionResult NombreAgente(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente, new[] { "Ana Torres", "María López" });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }

    [HttpGet("agencia")]
    public IActionResult Agencia(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Agencia, new[] { "Torres Realty", "Férnandez Inmuebles" });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }

[HttpGet("tipo")]
    public IActionResult Tipo(){
    MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Tipo, new[] { "Terreno" });

        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }




}