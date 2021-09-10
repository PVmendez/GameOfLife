using System;
using System.IO;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
			string url = @"../../assets/board.txt";
			string content = File.ReadAllText(url);

            bool[,] estado = Celula.EstadoFromString(content);
		    GameOfLife game = new GameOfLife(estado);
		
		    Console.WriteLine(Celula.EstadoToString(game.Estado));
		    while(true)
		    {
			    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			    if (keyInfo.Key == ConsoleKey.Q) break;
			    game.Tablero();
			    for(byte i = 0; i < 8; i++);
    			Console.WriteLine(Celula.EstadoToString(game.Estado));
	    	}
        }
    }
}
