
try
{
    try
    {
        AbrirArchivo("C:\\Users\\chaud\\Desktop\\no_existe.txt");
        //throw new Exception("Aqui lanzo una excepción mía");
    }
    catch (Exception ex)
    {
        throw new Exception("Ocurrió un error al ejecutar el método AbrirArchivo, el error fue: " + ex.Message);
        //Console.WriteLine("Ocurrió un error: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("Finally ejecutado!");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrió un error dentro del try-cath. El error fue: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally de mas afuera ejecutado!");
}

Console.WriteLine("El programa ha finalizado!");

void AbrirArchivo(string path)
{
	try
	{
        File.Open(path, FileMode.Open);
    }
	catch (Exception)
	{
		throw new Exception("Lo siento, este archivo no existe en la ruta especificada.");
	}
}