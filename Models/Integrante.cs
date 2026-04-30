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
    public int getEdad()
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - FechaDeNacimiento.Year;

            // Si todavía no cumplió años este año, restamos 1
    if (FechaDeNacimiento.Date > hoy.AddYears(-edad))
    {
        edad--;
    }

    return edad;
    }
    public List<string> getFam()
    {
        return Familiares;
    }
       public List<string> getIntereses()
    {
        return Intereses;
    } 
    

}