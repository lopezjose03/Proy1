using System.Collections;
using Newtonsoft.Json;
// See https://aka.ms/new-console-template for more information
//string nombre = "Jose";
//Console.WriteLine($"Mi nombre es {nombre} desde el main");

//Saludo(nombre);
//Console.WriteLine("#######################################################################");
//TipoDato();
//Invertir();

LoadJson();
void LoadJson(){
    using (StreamReader r = new StreamReader("customers.json"))
    {
        string json = r.ReadToEnd();
        List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);
        //var resp1 = customers.Find(it => it.city == "London");
        //var resp2 = customers.FindAll(it => it.city == "London");
        //var resp3 = customers.FindAll(it => it.companyName.StartsWith("P"));
        //Console.WriteLine($"Tipo de resp es: {resp.GetType()}");

 

        // MostrarEmpresa(resp);
        ListarEmpresas(customers);
    }
}
void ListarEmpresas(List<Customer>datos)
{
    
}


void Invertir(){

    Console.WriteLine("Escribe algo para invertirlo: ");
    string? palabra = Console.ReadLine();

    if (palabra is not null){
        char[] Vpalabra = palabra.ToCharArray();
        Array.Reverse(Vpalabra);
        Console.WriteLine(Vpalabra);
    }



}


void TipoDato(){
    ushort minUshort = ushort.MinValue;
    ushort maxUshort = ushort.MaxValue;
    short minShort = short.MinValue;
    short maxShort = short.MaxValue;

    ulong minUlong = ulong.MinValue;
    ulong maxUlong = ulong.MaxValue;
    long minLong = long.MinValue;
    long maxLong = long.MaxValue;

    Console.WriteLine($"El ushort va desde {minUshort} hasta {maxUshort}"); 
    Console.WriteLine($"El short va desde {minShort} hasta {maxShort}");

    Console.WriteLine($"El ulong va desde {minUlong} hasta {maxUlong}"); 
    Console.WriteLine($"El long va desde {minLong} hasta {maxLong}");
}

void Saludo(string nombre)
{
    string apellido = "López";
    Console.WriteLine($"Saludo desde metodo soy {nombre} {apellido} ");
}

public class Customer {
    public string id {get; set; }
    public string companyName {get; set; }
    public string contactName {get; set; }
    public string contactTitle {get; set; }
    public string address {get; set; }
    public string city {get; set; }
    public string postalCode {get; set; }
    public string country {get; set; }
    public string phone {get; set; }
    public string fax {get; set; }
}