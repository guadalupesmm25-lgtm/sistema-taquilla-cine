using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cine_1989
{ 
    public class Usuario
    {
        public string User_Name;
        public string User_Password;
        public string Cinema;
        private string opcion;
        private int cicle = 1;


        public void Usuarios ()
        {
            Console.WriteLine("Indica tu usuario a continuacion:");
            User_Name = Console.ReadLine();
            Console.WriteLine("Indica tu contrasena:");
            User_Password = Console.ReadLine();
            do
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Indica tu Cine favorito del area Norte\n 1.-Vallejo \n 2.- Plaza Tlane \n 3.- Multiplaza Arboledas \n 4.-Arcana Norte\n 5.- Sentura ");
                Console.WriteLine("Ingresa el numero de cine que deseas");
                opcion = (Console.ReadLine());
                switch(opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Seleccionaste: VALLEJO");
                        Cinema = "VALLEJO";
                        cicle = 0;
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Seleccionaste: PLAZA TLANE");
                            Cinema = "PLAZA TLANE";
                            cicle = 0;
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Seleccionaste: MULTIPLAZA ARBOLEDAS");
                        Cinema = "MULTIPLAZA ARBOLEDAS";
                        cicle = 0;
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Seleccionaste: ARCANA NORTE");
                        Cinema = "ARCANA NORTE";
                        cicle = 0;
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Seleccionaste: SENTURA");
                        Cinema = "SENTURA";
                        cicle = 0;
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Opcion no valida. \n Intentalo de nuevo");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                            break;
                }
            } while (cicle == 1);
        }
        public string getUsers_Info ()
        {
           return "Bienvenido: "+User_Name+"\n Cine seleccionado: "+ Cinema+ "";
        }
    }

    class Movie_Menu : Usuario
    {
        public int opcionmov,quantity=100,cantidad,sala,repetir_menu=1;
        public string pelicula_selec ,error,idioma;
        public double precio;
        public void Movies()
        {
            do
            {


                Console.WriteLine("El precio del boleto para las pantallas IMAX es de $120");
                Console.WriteLine("A continuacion te presentamos la cartelera de peliculas que estan disponibles en el complejo que seleccionaste:");
                Console.WriteLine("Por vafor, elige la pelicula que quieras ver, indicando el numero de la opcion: ");
                Console.WriteLine("1.- The Flash - Sala 5 - ESP");
                Console.WriteLine("2.- Joker - Sala 1 - ENG");
                Console.WriteLine("3.- The Batman - Sala 4- ESP");
                Console.WriteLine("4.- Wonder Woman - Sala 3 - ENG");
                Console.WriteLine("5.- The Flash - Sala 2- ENG");
                Console.WriteLine("6.- Regresar al menu anteriror");
                opcionmov = int.Parse(Console.ReadLine());
                switch (opcionmov)
                {
                    case 1:
                        Console.WriteLine("Seleccionaste la pelicula 'The Flash'");
                        pelicula_selec = "The Flash";
                        Console.WriteLine("Indica la cantidad de boletos que deseas comprar");
                        cantidad = int.Parse(Console.ReadLine());
                        if (cantidad <= quantity)
                        {
                            quantity = quantity - cantidad;
                            precio = ((120 * cantidad) * 1.16);
                            Console.BackgroundColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("Gracias, quedo confirmada tu reservacion\n Disfruta tu funcion");
                            sala = 5;
                            idioma = "ESP";
                            repetir_menu = 0;
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Una disculpa, por el momento ya no hay boletos disponibles para la funcion que desdeas ver.\n Regresaras al menu de seleccion.");
                            error = "error";
                            Console.Clear();
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Seleccionaste la pelicula 'Joker'");
                        pelicula_selec = "Joker";
                        Console.WriteLine("Indica la cantidad de boletos que deseas comprar");
                        cantidad = int.Parse(Console.ReadLine());
                        if (cantidad <= quantity)
                        {
                            quantity = quantity - cantidad;
                            precio = ((120 * cantidad) * 1.16);
                            Console.BackgroundColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("Gracias, quedo confirmada tu reservacion\n Disfruta tu funcion");
                            sala = 1;
                            idioma = "ENG";
                            repetir_menu = 0;
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Una disculpa, por el momento ya no hay boletos disponibles para la funcion que desdeas ver.\n Regresaras al menu de seleccion.");
                            error = "error";
                            Console.Clear();
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Seleccionaste la pelicula 'The Batman'");
                        pelicula_selec = "The Batman";
                        Console.WriteLine("Indica la cantidad de boletos que deseas comprar");
                        cantidad = int.Parse(Console.ReadLine());
                        if (cantidad <= quantity)
                        {
                            quantity = quantity - cantidad;
                            precio = ((120 * cantidad) * 1.16);
                            Console.BackgroundColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("Gracias, quedo confirmada tu reservacion\n Disfruta tu funcion");
                            sala = 4;
                            idioma = "ESP";
                            repetir_menu = 0;
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Una disculpa, por el momento ya no hay boletos disponibles para la funcion que desdeas ver.\n Regresaras al menu de seleccion.");
                            error = "error";
                            Console.Clear();
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Seleccionaste la pelicula 'Wonder Woman'");
                        pelicula_selec = "Wonder Woman";
                        Console.WriteLine("Indica la cantidad de boletos que deseas comprar");
                        cantidad = int.Parse(Console.ReadLine());
                        if (cantidad <= quantity)
                        {
                            quantity = quantity - cantidad;
                            precio = ((120 * cantidad) * 1.16);
                            Console.BackgroundColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            sala = 3;
                            idioma = "ENG";
                            repetir_menu = 0;
                            Console.WriteLine("Gracias, quedo confirmada tu reservacion\n Disfruta tu funcion");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Una disculpa, por el momento ya no hay boletos disponibles para la funcion que desdeas ver.\n Regresaras al menu de seleccion.");
                            error = "error";
                            Console.Clear();
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Seleccionaste la pelicula 'Young Justice'");
                        pelicula_selec = "Young Justice";
                        Console.WriteLine("Indica la cantidad de boletos que deseas comprar");
                        cantidad = int.Parse(Console.ReadLine());
                        if (cantidad <= quantity)
                        {
                            quantity = quantity - cantidad;
                            precio = ((120 * cantidad) * 1.16);
                            Console.BackgroundColor = ConsoleColor.Green; Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("Gracias, quedo confirmada tu reservacion\n Disfruta tu funcion");
                            sala = 2;
                            idioma = "ENG";
                            repetir_menu = 0;
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Una disculpa, por el momento ya no hay boletos disponibles para la funcion que desdeas ver.\n Regresaras al menu de seleccion.");
                            error = "error";
                            Console.Clear();
                            Console.ReadLine();
                        }
                        break;
                    case 6: repetir_menu = 0;
                        error= "SALIDA";
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Erorr, opcion no valida");
                        break;
                }
            } while (repetir_menu == 1);
        }
        public string getMovTicket ()
        {
           return "Te mostramos un resumen de tu compra: \n Usuario: "+User_Name+"\n Cine seleccionado: "+ Cinema+ "\n Pelicula seleccionada: " +pelicula_selec+"\n Precio total + impuestos: $"+precio+"\n Salas: "+sala+"\n Idioma: "+idioma+"";
        }
    }
    
    class Food_Menu : Usuario
    {
        public int menu;
        public string seleccion,sabor_refresco,sabor_icee;
        public double total;
        public void Foods()
        {
            Console.WriteLine("Elegiste la opcion de Alimentos");
            Console.WriteLine("A continuacion te presentaremos el menu dispoble");
            Console.WriteLine("1.-Combo Pareja");
            Console.WriteLine("2.-Combo Cuates");
            Console.WriteLine("3.-Combo M&M's");
            Console.WriteLine("4.-Combo ICEE");
            Console.WriteLine("5.-Combo Nachos");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                
                case 1:Console.Clear();
                    Console.WriteLine("Seleccionaste 'Combo Pareja'");
                    seleccion = "Combo Pareja";
                    total = (385.00) * 1.16;
                    Console.WriteLine("Indica el sabor de los refrescos");
                    sabor_refresco = Console.ReadLine();    
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste 'Combo Cuates'");
                    seleccion = "Combo Cuates";
                    total = (231.00)*1.16;
                    Console.WriteLine("Indica el sabor de los refrescos");
                    sabor_refresco = Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste 'Combo M&M's'");
                    seleccion = "Combo M&M's";
                    total = (396.00) * 1.16;
                    Console.WriteLine("Indica el sabor de los refrescos");
                    sabor_refresco = Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste 'Combo ICEE'");
                    seleccion = "Combo ICEE";
                    total = (420.32) * 1.16;
                    Console.WriteLine("Indica el sabor de los ICEE");
                    sabor_icee = Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Seleccionaste 'Combo Nachos'");
                    seleccion = "Combo Nachos";
                    total = (345.12) * 1.16;
                    Console.WriteLine("Indica el sabor de los refrescos");
                    sabor_refresco = Console.ReadLine();
                    break;

            }

        }
        public string getFoodTicket()
        {
            return "Te mostramos un resumen de tu compra en dulceria: \n Usuario: " + User_Name + "\n Cine seleccionado: " + Cinema + "\n Combo Seleccionado: " + seleccion + "\n Precio total + impuestos: $" + total + "\nSabor de refrescos: "+sabor_refresco+"\nSabor ICEE: "+sabor_icee+"";
        }
    }

    internal class Program
        
    {
        
        static void Main(string[] args)
        {
            string opcion, usuario_mov = null, usuario_food = null, cinema_mov = null, cinema_food = null, pelicula_selecionada = null, saborrefrescos = null, saboricee = null, seleccion_combo = null, error_mov = null, mov_idioma = null;
            int repetir = 0, mov_sala=0;
            double precio_mov=0, total_food=0;
            do
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Hola, por favor selecciona una de las opciones disponibles");
                Console.WriteLine("1.- Menu de Peliculas");
                Console.WriteLine("2.- Menu de Alimentos");
                Console.WriteLine("3.- Recibos");
                Console.WriteLine("4.- Creditos");
                Console.WriteLine("5.- Salir");
                opcion = Console.ReadLine();
                Movie_Menu movmenu = new Movie_Menu();
                Food_Menu foodmenu = new Food_Menu();
                if (opcion == "1" || opcion == "Peliculas")
                {
                    Console.Clear();
                    
                    movmenu.Usuarios();
                    Console.Clear() ;
                    Console.WriteLine(movmenu.getUsers_Info());
                    movmenu.Movies();
                    Console.Clear() ;
                    error_mov = movmenu.error;
                    if (error_mov == "error")
                    {
                        Console.WriteLine("Por favor intenta de nuevo, te llevaremos a la pagina de inicio");
                        Console.ReadLine();
                    }
                    else if (error_mov == "SALIDA")
                    {

                    }
                             
                    else
                    {
                        Console.WriteLine(movmenu.getMovTicket());
                        usuario_mov = movmenu.User_Name;
                        cinema_mov = movmenu.Cinema;
                        pelicula_selecionada = movmenu.pelicula_selec;
                        precio_mov = movmenu.precio;
                        error_mov = movmenu.error;
                        mov_sala = movmenu.sala;
                        mov_idioma = movmenu.idioma;    
                        Console.ReadLine();
                    }
                   

                    
                    
                }
                else if (opcion == "2" || opcion == "Alimentos")
                {
                    Console.Clear();
                    
                    foodmenu.Usuarios();
                   foodmenu.Foods();
                    Console.WriteLine(foodmenu.getUsers_Info());
                    Console.WriteLine(foodmenu.getFoodTicket());
                    usuario_food = foodmenu.User_Name;
                    cinema_food = foodmenu.Cinema;
                    total_food = foodmenu.total;
                    saboricee = foodmenu.sabor_icee;
                    saborrefrescos = foodmenu.sabor_refresco;
                    seleccion_combo = foodmenu.seleccion;
                    Console.ReadLine();
                }
                else if (opcion == "3" || opcion == "Recibos")
                {
                    Console.Clear();
                    Console.WriteLine("Te mostramos un resumen de tu compra: \n Usuario: " + usuario_mov + "\n Cine seleccionado: " + cinema_mov + "\n Pelicula seleccionada: " + pelicula_selecionada + "\n Precio total + impuestos: $" + precio_mov + "\nSala: " +mov_sala+"\n Idioma: " +mov_idioma+"");
                    Console.WriteLine("\n\n\n\n\nTe mostramos un resumen de tu compra en dulceria: \n Usuario: " + usuario_food + "\n Cine seleccionado: " + usuario_food + "\n Combo Seleccionado: " + seleccion_combo + "\n Precio total + impuestos: $" + total_food + "\nSabor de refrescos: " + saborrefrescos + "\nSabor ICEE: " + saboricee + "");
                  
                    Console.ReadLine();
                }
                else if (opcion == "5" || opcion == "Salir")
                    {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\t \t \t  Gracias por dejar a Cine 1989 ser tu cine de preferencia \n \t \t \t\t\t 'Cause we never go out of Style'");
                    repetir = 1;
                    }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Opcion no valida. \n Intentalo de nuevo");
                    Console.WriteLine("Presiona una tecla para continuar");
                    Console.ReadLine();
                    Console.WriteLine("Opcion no valida, por favor intenta de nuevo");
                }
            }while (repetir==0);
            
            Console.ReadLine ();    
        }
    }
}
