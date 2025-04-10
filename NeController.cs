using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/ne")]
public class NeController : Controller {
  
    [HttpGet("tipo")]
     public IActionResult Tipo(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, "Terreno");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("operacion")]
     public IActionResult Operacion(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion, "Venta");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("pisos")]
     public IActionResult Pisos(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Pisos, 0);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("baños")]
     public IActionResult Baños(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Baños, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("tienepatio")]
     public IActionResult TienePatio(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Ne("TienePatio", "true");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }

}