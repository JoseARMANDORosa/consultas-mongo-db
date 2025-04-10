using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-venta")]
    public IActionResult ListarVenta () {
        //Muestra todas las propiedades cuya operación sea Venta

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Venta");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("listar-casa")]
    public IActionResult ListarCasa () {
       //Muestra todos los tipos que sean casa

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Casa");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
    [HttpGet("listar-nombreagente")]
    public IActionResult ListarNombreAgente () {
       //Muestra todos los tipos que sean casa

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Ana Torres");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
   [HttpGet("listar-agencia")]
    public IActionResult ListarAgencia () {
       //Muestra todos las agencias que sean Torres Realty

       MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Torres Realty");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }
   [HttpGet("listar-fechapublicacion")]
    public IActionResult ListarFechaPublicacion () {
       //Muestra todas las fechas de publicacion que sean 2025-01-02

        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.FechaPublicacion, "2025-01-02");
        var lista = collection.Find(filtro).ToList();
        return Ok (lista);
    }

}