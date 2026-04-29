public class Grupo
{
    private Dictionary<int, Integrante> Integrantes;
    public Grupo()
    {
        Integrantes = new Dictionary<int, Integrante>{};
        CargaDatosManual();
    }
    private void CargaDatosManual()
    {
        Integrantes.Add(49761294,new Integrante("Jorge",new DateTime(2009,9,27),"images/jorge.jpg",new List <string>{"mama", "papa", "hermano"},new List <string>{"manga","futbol","roblox","cubo rubik","series"}));
        Integrantes.Add(50235299,new Integrante("Fran", new DateTime(2010,4,14),"images/fran.jpg", new List <string>{"mama", "papa", "hermano"},new List <string>{"tenis","minecraft","heavy metal"}));
        Integrantes.Add(50235173,new Integrante("Dante",new DateTime(2010,4,5),"images/dante.jpg", new List <string>{"mama", "papa", "hermana"},new List <string>{"dormir","jugar","no estudiar"}));
        Integrantes.Add(49758734,new Integrante("Rafa", new DateTime(2009,9,9),"images/rafa.jpg",  new List <string>{"mama", "papa", "hermano"},new List <string>{"cubo rubik","anime","lol"} ));
    }
    public Dictionary<int, Integrante> getIntegrantes()
    {
        return Integrantes;
    }
    public Integrante getXdni(int dni)
    {
        Integrante integrante = null;
        foreach (var item in Integrantes.Keys)
        {
            if(dni == item)
            {
                integrante =  Integrantes[item];
            }            
        }

        return integrante;
    }

}

