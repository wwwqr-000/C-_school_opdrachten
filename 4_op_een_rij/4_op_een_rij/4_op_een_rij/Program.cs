using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_op_een_rij {
    internal class Program {

        static void tekenBoard(int beurt, string player1, string player2, int[,] board) {
            for (int y = 0; y < board.GetLength(1); y++) {
                Console.Write("|");
                for (int x = 0; x < board.GetLength(0); x++) {
                    Console.Write("----");
                }
                Console.Write("|");
                Console.Write("\n");
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void Main(string[] args) {
            int[,] board = new int[6, 7];
            int beurt = 0;
            string player1, player2;
            Console.Write("Wat is je naam, speler 1?\n> ");
            player1 = Console.ReadLine();
            Console.Clear();
            Console.Write("Wat is je naam, speler 2?\n> ");
            player2 = Console.ReadLine();
            Console.Clear();
            while (true) {
                tekenBoard(beurt, player1, player2, board);
            }
        }
    }
}
