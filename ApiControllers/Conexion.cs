public class Motos : ControllerMotos {
    [HttpGet("sql")]
    public IActionResult ListarMotosSql(){
        List<MotosSQL> lista = new List<MotosSQL>()
       
     sqlMotos conn = new sqlMotos (Motos.SQL_SERVER);
     sqlcommand cmd = new sqlcommand ("select IdMotos,Motos from Motos");
     cmd.Connection = conn;
     cmd.CommandType = System.Data.CommandType.Text;
     cmd.Connection.Open();
       
     sqlDataReader reader = cmd.Executereader();

     while (reader.Read()){
        MotosSQL Motos = new Carrera();
        Motos.IdMotos = reader.GetInt16("IdMotos");
        Motos.Motos = reader.GetString("Motos");

        lista.Add(carrera);

    }

    reader.Close();
    conn.Close();

    return Ok(lista);
 }

    [HttpGet("mongo")]

    public IActionResult ListarMotosMongoDb(){
        MongoClient client = new MongoClient(MotosConexion.MONGO_DB);
        var db = client.GetDatabase("Practica2_Motos");
        var collection = db.GetCollection<MotosMongo>("Motos");

        var lista = collection.Find(FilterDefinition<MotosMongo>.empty).ToList();
        
        return Ok(lista);
    }
}