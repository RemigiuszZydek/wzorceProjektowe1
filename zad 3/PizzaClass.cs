public class Pizza {
    public string Ciasto {get;set;}
    public string Sos {get;set;}
    public string AddSer {get;set;}
    public List<string> AddDodatki {get;set;} = new List<string>();
    public List<string> AddPrzyprawy {get;set;}= new List<string>();

    public override string ToString(){
        return $"Pizza z ciastem {Ciasto}, Sos : {Sos}, Ser: {AddSer}, Dodatki: {string.Join(", ",AddDodatki)}, Przyprawy: {string.Join(", ",AddPrzyprawy)} ";
    } 
}