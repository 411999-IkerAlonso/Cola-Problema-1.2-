using Problema_1._2;
using System.Drawing;
using System.Runtime.CompilerServices;

//Problema 1.2:
//Colas.Desarrollar una clase Cola que implemente la interfaz definida en el
//problema anterior pero esta vez utilizando un objeto List. Tener en cuenta que una
//Cola es una estructura FIFO (Primero en entrar primero en salir

Cola cola = new Cola();

cola.Añadir(5);
cola.Añadir(8);
cola.Añadir(19);

Console.WriteLine(cola.Primero());
Console.WriteLine(cola.EstaVacia());
cola.Extraer();
Console.WriteLine(cola.Primero());