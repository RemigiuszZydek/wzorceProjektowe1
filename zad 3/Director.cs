public class Director {
    public void MakeMargharita(IPizza pizza){
        pizza.Ciasto("cieńkie");
        pizza.Sos("pomidorowy");
        pizza.AddSer("mozarella");
        pizza.AddDodatki(new string[] {"bazylia","rozmaryn"});
        pizza.AddPrzyprawy(new string[] {"sól","oliwa z oliwek"});
    }
}