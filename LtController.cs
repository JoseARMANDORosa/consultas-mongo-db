using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/lt")]
public class LtController : Controller {
    [HttpGet("venta-costo")]
    public IActionResult VentaCosto(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroOperacion = Builders<Inmueble>.Filter.Lt(x => x.Operacion, "Venta");
        var filtroCosto = Builders<Inmueble>.Filter.Lt(x => x.Costo, 42367);
       
        var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroOperacion, filtroCosto);
        var lista = collection.Find(filtroCompuesto).ToList();
        return Ok (lista);
    }
    [HttpGet("metrosterreno")]
    public IActionResult MetrosTerreno(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerreno, 853);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }    
    [HttpGet("baños")]
    public IActionResult Baños(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Baños, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("metrosconstruccion")]
    public IActionResult MetrosConstruccion(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 578);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("pisos")]
    public IActionResult Pisos(){

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
}

