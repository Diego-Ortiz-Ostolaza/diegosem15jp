using ejericicio4;
string regresar;

Productos p= new Productos();


do
{
    Console.WriteLine("1. Registrar");
    Console.WriteLine("2. Mostrar");
    Console.WriteLine("3. Modificar");

    Console.Write("Ingrese opción: ");
    int opcion= int.Parse(Console.ReadLine());

    switch (opcion)
    {

        case 1: p.insertar(); break;
        case 2: p.mostrar(); break;
        case 3: break;
    }
    Console.WriteLine("\nRegresar al menú [si]: ");
    regresar=Console.ReadLine();
    Console.Clear();

}while (regresar=="si");













