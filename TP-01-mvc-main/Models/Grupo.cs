Class Grupo
{
    private Dictionary<int, Integrante> Integrantes;
    public Grupo()
    {
        
    }
    private void CargaDatosManual()
    {
        Integrantes.Add(1,integrante(49761294,"jorge",(2009,9,27) ,/*foto*/,{"mama", "papa", "hermano"},{"manga","futbol","roblox","cubo rubik","series"}));
        Integrantes.Add(2,integrante(50235299,"Francisco", (2010,4,14),/*foto*/,{"mama", "papa", "hermano"},{"tenis","minecraft","heavy metal"}));
        Integrantes.Add(3,integrante(50235173,"dante", (2010,4,5),"images/IMG-20260421-WA0000.jpg",{"mama", "papa", "hermana"},{"dormir","jugar","no estudiar"}));
        Integrantes.Add(4,integrante(49758734, "rafa", (2009,9,9), /*foto*/,{"mama", "papa", "hermano"},{"cubo rubik","anime","lol"} ));
    }
}
