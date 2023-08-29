List<string> productos = new()
{
    "Cachito",
    "Tequeños",
    "Queso",
};


var path = "C:\\Users\\chaud\\Desktop\\practica.naho";
var contenido = File.ReadAllText(path);
var productosSeparados = contenido.Split("\n");

foreach (var producto in productosSeparados)
{
    Console.WriteLine(producto);
}

//Console.WriteLine(contenido);

//File.AppendAllLines(path, productos);

//Console.WriteLine("------------------------------------------------------------------------------");

//var contenidoFinal = File.ReadAllText(path);
//Console.WriteLine(contenidoFinal);