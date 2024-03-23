public class Client {
    static void Main(string[] args){
        var builder = new PizzaBuilder();
        var director = new Director();

        director.MakeMargharita(builder);
        var pizza = builder.GetPizza();

        Console.WriteLine(pizza);
    }
}