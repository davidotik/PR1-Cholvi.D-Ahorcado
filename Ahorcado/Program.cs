﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green; //Pinta de verde el titulo del Juego.
            


            Console.Clear(); //mUESTRA EL TITULO DEL JUEGO EN ASCII
            Console.WriteLine(@"     ___           ___           ___           ___           ___           ___           ___           ___ ");
            Console.WriteLine(@"    /\  \         /\__\         /\  \         /\  \         /\  \         /\  \         /\  \         /\  \");
            Console.WriteLine(@"   /::\  \       /:/  /        /::\  \       /::\  \       /::\  \       /::\  \       /::\  \       /::\  \");
            Console.WriteLine(@"  /:/\:\  \     /:/__/        /:/\:\  \     /:/\:\  \     /:/\:\  \     /:/\:\  \     /:/\:\  \     /:/\:\  \");
            Console.WriteLine(@" /::\~\:\  \   /::\  \ ___   /:/  \:\  \   /::\~\:\  \   /:/  \:\  \   /::\~\:\  \   /:/  \:\__\   /:/  \:\  \");
            Console.WriteLine(@"/:/\:\ \:\__\ /:/\:\  /\__\ /:/__/ \:\__\ /:/\:\ \:\__\ /:/__/ \:\__\ /:/\:\ \:\__\ /:/__/ \:|__| /:/__/ \:\__\");
            Console.WriteLine(@"\/__\:\/:/  / \/__\:\/:/  / \:\  \ /:/  / \/_|::\/:/  / \:\  \  \/__/ \/__\:\/:/  / \:\  \ /:/  / \:\  \ /:/  /");
            Console.WriteLine(@"     \::/  /       \::/  /   \:\  /:/  /     |:|::/  /   \:\  \            \::/  /   \:\  /:/  /   \:\  /:/  /");
            Console.WriteLine(@"     /:/  /        /:/  /     \:\/:/  /      |:|\/__/     \:\  \           /:/  /     \:\/:/  /     \:\/:/  /");
            Console.WriteLine(@"    /:/  /        /:/  /       \::/  /       |:|  |        \:\__\         /:/  /       \::/__/       \::/  /");
            Console.WriteLine(@"    \/__/         \/__/         \/__/         \|__|         \/__/         \/__/         ~~            \/__/");


            Console.ResetColor();//Pone otyra vez los colores por defecto.

            
                                                                                                                                                                                        
            Console.WriteLine("Bienvenido al juego del ahorcado.");//Muestra un mensaje de vienvenida al juego.
           

            Console.ReadKey();
            
            string[] palabra = new string[5];
            palabra[1] = "raton";
            palabra[2] = "telefono";
            palabra[3] = "pantalla";
            palabra[4] = "portatil";

            int contador = 0;
            int totalLetras = 0;
            int na = 0;

            string palabraescogida = "";
            string palabraResultado = "";

            Random aleatorio = new Random();

            na = aleatorio.Next(1, 4);
            palabraescogida = palabra[na];
            totalLetras = palabraescogida.Length;

            Console.WriteLine("tiene tantas "+totalLetras+"letras");

            for (contador = 0; contador <= totalLetras - 1; contador++)
            {

                if (palabraescogida.Substring(contador, 1) != " ")
                    palabraResultado = palabraResultado + "@";
                else
                    palabraResultado = palabraResultado + " ";
            }
            Console.WriteLine(palabraResultado);
            int intentos = 0;

            do
            {
                
                string letrapulsada="";
                string letraenviada="";

                Boolean bien=false;
                Console.WriteLine("Empezemos presione una tecla");
                letrapulsada=Console.ReadLine();

                for(contador=0;contador<=totalLetras-1;contador++)
                {
                    letraenviada=palabraescogida.Substring(contador,1);
                    if(letraenviada.Equals(letrapulsada))
                    {
                        palabraResultado=palabraResultado.Remove(contador,1);
                        palabraResultado=palabraResultado.Insert(1,letrapulsada);
                        bien=true;

                    }
                    if(bien)
                    {
                        Console.WriteLine(""+palabraResultado);
                    }
                    else
                    {
                        intentos++;
                        Console.WriteLine("La letra no existe"+intentos);
                 
                    }
                
                if(intentos==7)
                {
 Console.ForegroundColor = ConsoleColor.Red;//Muestra el dibujo del ahorcado con siete fallos es decir que ja habremos perdido.
            Console.WriteLine("_________");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  X ");
            Console.WriteLine(@"| /|\ ");
            Console.WriteLine(@"| / \ ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");

            Console.ResetColor();
            Console.WriteLine(" ██░ ██  ▄▄▄        ██████     ██▓███  ▓█████  ██▀███  ▓█████▄  ██▓▓█████▄  ▒█████ ");         //Muestra el final del juego diciendo quehas perdido echo con ASCII
            Console.WriteLine("▓██░ ██▒▒████▄    ▒██    ▒    ▓██░  ██▒▓█   ▀ ▓██ ▒ ██▒▒██▀ ██▌▓██▒▒██▀ ██▌▒██▒  ██▒");       
            Console.WriteLine("▒██▀▀██░▒██  ▀█▄  ░ ▓██▄      ▓██░ ██▓▒▒███   ▓██ ░▄█ ▒░██   █▌▒██▒░██   █▌▒██░  ██▒");     
            Console.WriteLine("░▓█ ░██ ░██▄▄▄▄██   ▒   ██▒   ▒██▄█▓▒ ▒▒▓█  ▄ ▒██▀▀█▄  ░▓█▄   ▌░██░░▓█▄   ▌▒██   ██░");    
            Console.WriteLine("░▓█▒░██▓ ▓█   ▓██▒▒██████▒▒   ▒██▒ ░  ░░▒████▒░██▓ ▒██▒░▒████▓ ░██░░▒████▓ ░ ████▓▒░ ██▓");   
            Console.WriteLine(" ▒ ░░▒░▒ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   ▒▓▒░ ░  ░░░ ▒░ ░░ ▒▓ ░▒▓░ ▒▒▓  ▒ ░▓   ▒▒▓  ▒ ░ ▒░▒░▒░  ▒▓▒");   
            Console.WriteLine("▒ ░▒░ ░  ▒   ▒▒ ░░ ░▒  ░ ░   ░▒ ░      ░ ░  ░  ░▒ ░ ▒░ ░ ▒  ▒  ▒ ░ ░ ▒  ▒   ░ ▒ ▒░  ░▒");   
            Console.WriteLine(" ░  ░░ ░  ░   ▒   ░  ░  ░     ░░          ░     ░░   ░  ░ ░  ░  ▒ ░ ░ ░  ░ ░ ░ ░ ▒   ░ ");      
            Console.WriteLine("░  ░  ░      ░  ░      ░                 ░  ░   ░        ░     ░     ░        ░ ░    ░  ");

                    Console.ReadKey();
                    
                    

                }
                    if(intentos==6)
                    {
                         Console.WriteLine("__________________"); // Muestra el dibujo del ahorcado con seis fallos.
                         Console.WriteLine("|  | ");
                         Console.WriteLine("|  0 ");
                         Console.WriteLine(@"| /|\ ");
                         Console.WriteLine(@"| / \ ");
                         Console.WriteLine("| ");
                         Console.WriteLine("| ");
                         Console.WriteLine("__________________");


                    }
                    if(intentos==5)
                    {
                        Console.WriteLine("_________"); //Muestra el dibujo del ahorcado con cinco fallos.
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine(@"| /|\ ");
            Console.WriteLine(@"|   \ ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");
                  }


                    if(intentos==4)
                    {
                        Console.WriteLine("_________"); //Muestra el dibujo del ahorcado con quatro fallos.
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine(@"| /|\ ");
            Console.WriteLine("|  ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");
                    
                    }
                 
                    if(intentos==3)
                    {
                        Console.WriteLine("_________"); //Muestra el dibujo del ahorcado con tres fallos.
                        Console.WriteLine("|  | ");
                        Console.WriteLine("|  0 ");
                        Console.WriteLine(@"| |\ ");
                        Console.WriteLine(@"|  ");
                        Console.WriteLine("| ");
                        Console.WriteLine("| ");
                        Console.WriteLine("__________________");

                    }
                    if(intentos==2)
                    {
                        Console.WriteLine("_________"); //Muestra el dibujo del ahorcado con dos fallos.
                        Console.WriteLine("|  | ");
                        Console.WriteLine("|  0 ");
                        Console.WriteLine(@"| |");
                        Console.WriteLine(@"|  ");
                        Console.WriteLine("| ");
                        Console.WriteLine("| ");
                        Console.WriteLine("__________________");
                    }

                    if(intentos==1)
                    {
                        Console.WriteLine("_________"); // Mustra el dibujo del ahorcado con un fallo.
                        Console.WriteLine("|  | ");
                        Console.WriteLine("|  0 ");
                        Console.WriteLine(@"|  ");
                        Console.WriteLine(@"| ");
                        Console.WriteLine("| ");
                        Console.WriteLine("| ");
                        Console.WriteLine("__________________");
                    }
                    if(intentos==0)
                    {
                        Console.WriteLine("_________"); //Muestra el dibujo del ahorcado cuando no tiene ningun fallo.
                        Console.WriteLine("|  | ");
                        Console.WriteLine("|   ");
                        Console.WriteLine(@"|  ");
                        Console.WriteLine(@"|  ");
                        Console.WriteLine("| ");
                        Console.WriteLine("| ");
                        Console.WriteLine("__________________");

                    }
                    if (palabraescogida == palabraResultado) 
                    {
                        Console.WriteLine("enhorabuena ganaste");
                        break;
                    }
               }


            } while (intentos<7);      


           


            
      
 

            Console.ReadKey();
        }
    }
}
