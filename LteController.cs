using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/lte")]
public class Ltecontroller : Controller {
    [HttpGet("costos")]
     public IActionResult Costos(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 31200);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("metrosterreno")]
     public IActionResult MetrosTerreno(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosTerreno, 312);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("Pisos")]
     public IActionResult Pisos(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
   [HttpGet("metrosconstruccion")]
     public IActionResult MetrosConstruccion(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 104);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("baños")]
     public IActionResult Baños(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Baños, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}