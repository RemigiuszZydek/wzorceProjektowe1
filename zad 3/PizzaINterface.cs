public interface IPizza {
    void  Ciasto(string type);
    void  Sos(string type);
    void AddSer(string type);
    void AddDodatki(string[] dodatki);
    void AddPrzyprawy(string[] przyprawy);
    Pizza GetPizza();
}