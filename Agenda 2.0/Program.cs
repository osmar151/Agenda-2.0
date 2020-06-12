using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_2._0
{
    class Program
    {
        
        static string[,] agenda = new string[4, 10];
        static void Main(string[] args)
        {
            char menu = 'n';
            string linea = "";
            string usuario = "contacto no encotrado";
            string buscar = "";
            string buscar2 = "";
            int op = 0;


            while (menu ! = 's') 
            {

                Console.WriteLine(" 1.-crear contactos ");
                Console.WriteLine(" 2.-mostrar contactos ");
                Console.WriteLine(" 3.-buscar contactos ");
                Console.WriteLine(" 4.-salir ");
                Console.WriteLine(" opción: ");

                linea = Console.ReadLine();
                op = int.Parse(linea);



                if (op == 1)
                {
                    for (int f = 0; f < 10; f++)
                    {
                        Console.Write("ingrese nombre: ");
                        agenda[0, f] = Console.ReadLine();

                        Console.Write("ingrese apellido: ");
                        agenda[1, f] = Console.ReadLine();

                        Console.Write("ingrese direccion: ");
                        agenda[2, f] = Console.ReadLine();

                        Console.Write("ingrese telefono: ");
                        agenda[3, f] = Console.ReadLine();
                    }

                }

                else if (op == 2)
                {
                    for (int f = 0; f < 10; f++)
                    {
                        Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f]);
                    }

                }

                else if (op == 3)
                {
                    Console.Write("ingrese el nombre del contacto a buscar: ");
                    buscar = Console.ReadLine();

                    Console.Write("ingrese el apellido del contacto a buscar: ");
                    buscar2 = Console.ReadLine();

                    for (int f = 0; f < 10; f++)
                    {
                        if (buscar == agenda[0, f] && buscar2 == agenda[1, f])
                        {
                            usuario = agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f];
                        }


                    }
                }

                else if (op == 4)
                {
                    Console.WriteLine("desea salir [s/n] ");
                    linea = Console.ReadLine();
                    menu = char.Parse(linea);

                }
            }
                Console.WriteLine(usuario);


                Console.ReadKey();

            
        }
    }
}
