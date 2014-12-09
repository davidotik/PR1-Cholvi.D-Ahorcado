using System;
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
           

            Console.WriteLine("La palabra contiene letras y es algo que se encuentra a tu alredodor.");//Muestrea una frase por pantalla que es una pista.
            Console.ReadKey();
            
          
            Console.WriteLine("_________"); //Muestra el dibujo del ahorcado cuando no tiene ningun fallo.
            Console.WriteLine("|  | ");
            Console.WriteLine("|   ");
            Console.WriteLine(@"|  ");
            Console.WriteLine(@"|  ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");

            Console.WriteLine("_________"); // Mustra el dibujo del ahorcado con un fallo.
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine(@"|  ");
            Console.WriteLine(@"| ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");

            Console.WriteLine("_________"); //Muestra el dibujo del ahorcado con dos fallos.
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine(@"| |");
            Console.WriteLine(@"|  ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");


            Console.WriteLine("_________"); //Muestra el dibujo del ahorcado con tres fallos.
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine(@"| |\ ");
            Console.WriteLine(@"|  ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");


            Console.WriteLine("_________"); //Muestra el dibujo del ahorcado con quatro fallos.
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine(@"| /|\ ");
            Console.WriteLine("|  ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");
            

            Console.WriteLine("_________"); //Muestra el dibujo del ahorcado con cinco fallos.
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine(@"| /|\ ");
            Console.WriteLine(@"|   \ ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");

            Console.WriteLine("__________________"); // Muestra el dibujo del ahorcado con seis fallos.
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine(@"| /|\ ");
            Console.WriteLine(@"| / \ ");
            Console.WriteLine("| ");
            Console.WriteLine("| ");
            Console.WriteLine("__________________");

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
    }
}
