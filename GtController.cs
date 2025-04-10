using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller {
    [HttpGet("costo")]
    public IActionResult Costo(){
        MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gt(X => X.Costo, 33421);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }
    [HttpGet("baño")]
    public IActionResult Baño(){
        MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gt(X => X.Baños, 1);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }
     
    [HttpGet("pisos")]
    public IActionResult Pisos(){
        MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gt(X => X.Pisos, 2);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }
    
    [HttpGet("metros-terreno")]
    public IActionResult MetrosTerreno(){
        MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gt(X => X.MetrosTerreno, 700);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }
    [HttpGet("MetrosConstruccion")]
    public IActionResult MetrosConstruccion(){
        MongoClient client =new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase ("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

      //  Obtener.............

        var filtro = Builders<Inmueble>.Filter.Gt(X => X.MetrosConstruccion, 880);
        var list = collection.Find(filtro).ToList();
        return Ok(list);
    }


}