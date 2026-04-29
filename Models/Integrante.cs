public class Integrante
{

    private string Nombre;
    private DateTime FechaDeNacimiento;
    private string Foto;
    List<string> Familiares;
    List<string> Intereses;
    public Integrante( string nombre, DateTime fecha, string foto, List<string> familiares, List<string> intereses)
    {
      
        Nombre = nombre;
        FechaDeNacimiento = fecha;
        Foto = foto;
        Familiares = familiares;
        Intereses = intereses;
    }
    public string getFoto()
    {
        return Foto;
    }
    public string getNombre()
    {
        return Nombre;
    }


}