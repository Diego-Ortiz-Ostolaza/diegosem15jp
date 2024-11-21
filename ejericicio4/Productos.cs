using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejericicio4
{
    internal class Productos
    {
        string[,] producto = new string[0, 3];
        int posicion = 0;
        public void redimensionar(int nuevoTamaño) {

            string[,] nuevoarreglo = new string[nuevoTamaño, 3];
            for (int i = 0; i < posicion; i++)
            {
                for (int j = 0; j <producto.GetLength(1); j++)
                {
                    nuevoarreglo[i, j]= producto[i, j];
                }
            }
            producto = nuevoarreglo;
        }

        public void insertar() {
            redimensionar(posicion+1);
            Console.Write("\nIngrese nombre: ");
            producto[posicion, 0] = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            producto[posicion, 1] = Console.ReadLine();
            Console.Write("Ingrese stock: ");
            producto[posicion, 2] = Console.ReadLine();
            posicion++;
            Console.WriteLine("\nProducto registrado correctamente!");
        }


        public void mostrar() { 
        for (int i = 0;i < posicion; i++)
            {
                Console.WriteLine("\nProducto N° "+(i+1));
                Console.WriteLine("Nombre: " + producto[i,0]);
                Console.WriteLine("Precio: "+producto[i,1]);
                Console.WriteLine("Stock: " + producto[i,2]);
                Console.WriteLine();

            }
        
        
        
        
        }









    }
}
