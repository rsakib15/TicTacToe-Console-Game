using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] mark = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int player = 1, i=0, choice;
            char turn;
            int flag = 0;

            while (i < 9)
            {
                Console.Clear();
                Console.WriteLine("Tic Tac Toe Game");
                Console.WriteLine("Player 1 ------ (X)");
                Console.WriteLine("Player 2 ------ (O)");
                Console.WriteLine();
                Console.WriteLine();
                i++;

                if (player % 2 == 1)
                    turn = 'X';
                else
                    turn = 'O';
    

                Console.WriteLine("                           " + mark[0] + "  |  " + mark[1] + "  |  " + mark[2]);
                Console.WriteLine("                         _____|_____|_____");
                Console.WriteLine("                           " + mark[3] + "  |  " + mark[4] + "  |  " + mark[5]);
                Console.WriteLine("                         _____|_____|_____");
                Console.WriteLine("                           " + mark[6] + "  |  " + mark[7] + "  |  " + mark[8]);
                Console.WriteLine("                              |     |     ");
   
       
                Console.WriteLine("Enter Choice: ");
                Object inp = Console.ReadLine();
                choice = Convert.ToInt32(inp);

                if (choice == 1 && mark[0] == '1')
                    mark[0] = turn;
                else if (choice == 2 && mark[1] == '2')
                    mark[1] = turn;
                else if (choice == 3 && mark[2] == '3')
                    mark[2] = turn;
                else if (choice == 4 && mark[3] == '4')
                    mark[3] = turn;
                else if (choice == 5 && mark[4] == '5')
                    mark[4] = turn;
                else if (choice == 6 && mark[5] == '6')
                    mark[5] = turn;
                else if (choice == 7 && mark[6] == '7')
                    mark[6] = turn;
                else if (choice == 8 && mark[7] == '8')
                    mark[7] = turn;
                else if (choice == 9 && mark[8] == '9')
                    mark[8] = turn;
                else
                    Console.WriteLine("Invalid Move");             


                player++;


                if (mark[0] == mark[1] && mark[0] == mark[2])
                    flag = 1;
                else if (mark[0] == mark[4] && mark[0] == mark[8])
                    flag = 1;
                else if (mark[0] == mark[3] && mark[0] == mark[6])
                    flag = 1;
                else if (mark[3] == mark[4] && mark[3] == mark[5])
                    flag = 1;
                else if (mark[6] == mark[7] && mark[6] == mark[8])
                    flag = 1;
                else if (mark[1] == mark[4] && mark[1] == mark[7])
                    flag = 1;
                else if (mark[2] == mark[5] && mark[2] == mark[8])
                    flag = 1;
                else if (mark[2] == mark[4] && mark[2] == mark[6])
                    flag = 1;
                else
                   flag=0;

                if (flag == 1)
                    break;
            }

            if (flag == 1)
            {
                Console.WriteLine("                           " + mark[0] + "  |  " + mark[1] + "  |  " + mark[2]);
                Console.WriteLine("                         _____|_____|_____");
                Console.WriteLine("                           " + mark[3] + "  |  " + mark[4] + "  |  " + mark[5]);
                Console.WriteLine("                         _____|_____|_____");
                Console.WriteLine("                           " + mark[6] + "  |  " + mark[7] + "  |  " + mark[8]);
                Console.WriteLine("                              |     |     ");

                Console.WriteLine("Player {0} win", player%2+1);
            }

            if (flag ==0 && i==9)
            {
                Console.WriteLine("                           " + mark[0] + "  |  " + mark[1] + "  |  " + mark[2]);
                Console.WriteLine("                         _____|_____|_____");
                Console.WriteLine("                           " + mark[3] + "  |  " + mark[4] + "  |  " + mark[5]);
                Console.WriteLine("                         _____|_____|_____");
                Console.WriteLine("                           " + mark[6] + "  |  " + mark[7] + "  |  " + mark[8]);
                Console.WriteLine("                              |     |     ");

                Console.WriteLine("Match Draw");
            }

        }
    }
}
