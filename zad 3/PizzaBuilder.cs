public class PizzaBuilder : IPizza {
    private Pizza _pizza = new Pizza();

    public void Ciasto(string type){
        _pizza.Ciasto=type;
    }
    public void Sos(string type){
        _pizza.Sos = type;
    }
    public void AddSer(string type){
        _pizza.AddSer = type;

    }
    public void AddDodatki(string[] dodatki){
        _pizza.AddDodatki.AddRange(dodatki);
    }
    public void AddPrzyprawy(string[] przyprawy){
        _pizza.AddPrzyprawy.AddRange(przyprawy);
    }
    public Pizza GetPizza(){
        Pizza result = _pizza;
        _pizza = new Pizza();
        return result;
    }
}