Class Integrante
{
    private int Dni;
    private string Nombre;
    private DateTime FechaDeNacimiento
    private string Foto;
    List<string> Familiares;
    List<string> Inteseres;
    public Integrante(int dni, string nombre, DateTime fecha, string foto, List<string> familiares, List<string> intereses)
    {
        Dni = dni;
        Nombre = nombre;
        FechaDeNacimiento = fecha;
        Foto = foto;
        Familiares = familiares;
        Intereses = intereses;
    }

}