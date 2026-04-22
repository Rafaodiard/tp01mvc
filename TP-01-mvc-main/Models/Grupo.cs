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
        Integrantes.Add(1,new Integrante(49761294,"jorge",new DateTime(2009,9,27) ,/*foto*/"",new List <string>{"mama", "papa", "hermano"},new List <string>{"manga","futbol","roblox","cubo rubik","series"}));
        Integrantes.Add(2,new Integrante(50235299,"Fran", new DateTime(2010,4,14),/*foto*/"",new List <string>{"mama", "papa", "hermano"},new List <string>{"tenis","minecraft","heavy metal"}));
        Integrantes.Add(3,new Integrante(50235173,"dante",new DateTime(2010,4,5),"images/dante.jpg",new List <string>{"mama", "papa", "hermana"},new List <string>{"dormir","jugar","no estudiar"}));
        Integrantes.Add(4,new Integrante(49758734, "rafa",new DateTime(2009,9,9), /*foto*/"",new List <string>{"mama", "papa", "hermano"},new List <string>{"cubo rubik","anime","lol"} ));
    }
    public Dictionary<int, Integrante> getIntegrantes()
    {
        return Integrantes;
    }
    public Integrante getXdni(int dni)
    {
        Integrante integrante = null;
        foreach (var item in Integrantes.Values)
        {
            if(dni == item.getDni())
            {
                integrante =  item;
            }            
        }

        return integrante;
    }

}

