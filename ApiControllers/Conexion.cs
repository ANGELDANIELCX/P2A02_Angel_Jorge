using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using MongoDB.Driver;

[ApiController]
[Route("Conexion")]
public class Motos : Controller {
   

    [HttpGet("mongo")]

    public IActionResult ListaDeMotosMongoDb(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Practica2_Angel_Jorge");
        var collection = db.GetCollection<MotosMongo>("ListaDeMotos");

        var lista = collection.Find(FilterDefinition<MotosMongo>.Empty).ToList();
        
        return Ok(lista);
    }
}