public class CineMongo
{
    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public string Año { get; set; } = string.Empty;
    public decimal Tiene_3D { get; set; }
    public decimal Tiene_IMAX { get; set; }
    public int Precio_promedio { get; set; }
    public int Cartelera_Actual { get; set; }
    public int Puntuacion { get; set; }
    public List<string> Cine { get; set; }
}