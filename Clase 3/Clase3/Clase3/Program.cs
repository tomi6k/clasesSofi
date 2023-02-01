// El usuario ingresará su nombre y sexo y el sistema le dira si es guei o no

//Console.WriteLine("Ingrese su nombre: ");
//string nombre = Console.ReadLine();

//Console.WriteLine("Hola, " + nombre + "¿que genero sos?");

//string genero = Console.ReadLine();

//if (genero == "Hombre")
//{
//    Console.WriteLine("Usted es un hombre");
//} else if (genero == "Mujer") {
//    Console.WriteLine("Usted es una mujer");
//} else
//{
//    Console.WriteLine("Usted es otro genero");
//}


//Console.ReadKey();


int contador = 0;

while (contador <= 50)
{
    contador++;
    Console.WriteLine(contador);
    if (contador == 45)
    {
        Console.WriteLine("Se dieron 45 vueltas");
        break;
    }
}