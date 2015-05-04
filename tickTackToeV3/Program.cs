using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickTackToeV3
{
    class Program
    {
        static void Main(string[] args)
        {


            //string a1 = ("1"); string a2 = ("2"); string a3 = ("3");
            //string b1 = ("4"); string b2 = ("5"); string b3 = ("6");
            //string c1 = ("7"); string c2 = ("8"); string c3 = ("9");
            int a1 = 1; int a2 = 2; int a3 = 3;
            int b1 = 4; int b2 = 5; int b3 = 6;
            int c1 = 7; int c2 = 8; int c3 = 9;
            string a51 = ("1"); string a52 = ("2"); string a53 = ("3");
            string b51 = ("4"); string b52 = ("5"); string b53 = ("6");
            string c51 = ("7"); string c52 = ("8"); string c53 = ("9");

            int y = 1;int z = 1;
                start:
           
                //flipFlop
                if(z == 100) { z = -100; } else { z = 100; }
        //usrInput
        usrInput:
            if (z == 100||z == -100)
            {
                //visual conversion
                if (a1 >= 20) { a51 = ("X"); } else if (a1 <= -20) { a51 = ("O"); }
                if (a2 >= 20) { a52 = ("X"); } else if (a2 <= -20) { a52 = ("O"); }
                if (a3 >= 20) { a53 = ("X"); } else if (a3 <= -20) { a53 = ("O"); }

                if (b1 >= 20) { b51 = ("X"); } else if (b1 <= -20) { b51 = ("O"); }
                if (b2 >= 20) { b52 = ("X"); } else if (b2 <= -20) { b52 = ("O"); }
                if (b3 >= 20) { b53 = ("X"); } else if (b3 <= -20) { b53 = ("O"); }

                if (c1 >= 20) { c51 = ("X"); } else if (c1 <= -20) { c51 = ("O"); }
                if (c2 >= 20) { c52 = ("X"); } else if (c2 <= -20) { c52 = ("O"); }
                if (c3 >= 20) { c53 = ("X"); } else if (c3 <= -20) { c53 = ("O"); }

                //display
                Console.WriteLine("\n" + a51 + a52 + a53 + "\n" + b51 + b52 + b53 + "\n" + c51 + c52 + c53 + "\n");
                Console.Write("Where do you want to play?; ");
                y = Convert.ToInt16(Console.ReadLine());
            }
            //inputEntagrate
            switch (y)
            {
                case 1: { if (a1 == 1) { a1 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }
                case 2: { if (a2 == 2) { a2 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }
                case 3: { if (a3 == 3) { a3 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }
                case 4: { if (b1 == 4) { b1 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }
                case 5: { if (b2 == 5) { b2 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }
                case 6: { if (b3 == 6) { b3 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }
                case 7: { if (c1 == 7) { c1 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }
                case 8: { if (c2 == 8) { c2 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }
                case 9: { if (c3 == 9) { c3 = z; } else { Console.WriteLine("Invalid move please try again."); goto usrInput; } break; }

            }
            

            //ai
            //priority
            double a11 = 0; double a22 = 0; double a33 = 0;
            double b11 = 0; double b22 = 0; double b33 = 0;
            double c11 = 0; double c22 = 0; double c33 = 0;

            int a41 = 0; int a42 = 0; int a43 = 0;
            int b41 = 0; int b42 = 0; int b43 = 0;
            int c41 = 0; int c42 = 0; int c43 = 0;
            int u = 0;

            if (a1 != 1 && a1 == z) { a11 = -9; a22 += 2; a33 += 1; b11 += 2; b22 += 2; c11 += 1; c33 += 1; }
            if (a2 != 2 && a2 == z) { a22 = -9; a11 += 1; a33 += 1; b22 += 2; c22 += 1;}
            if (a3 != 3 && a3 == z) { a33 = -9; a11 += 1; a22 += 2; b22 += 2; b33 += 2; c11 += 1; c33 += 1; }

            if (b1 != 4 && b1 == z) { b11 = -9; a11 += 1; b22 += 2; b33 += 1; c11 += 1;}
            if (b2 != 5 && b2 == z) { b22 = -9;}
            if (b3 != 6 && b3 == z) { b33 = -9; a33 += 1; b11 += 1; b22 += 2; c33 += 1;}

            if (c1 != 7 && c1 == z) { c11 = -9; a11 += 1; a33 += 1; b11 += 2; b22 += 2; c22 += 2; c33 += 1; }
            if (c2 != 8 && c2 == z) { c22 = -9; a22 += 1; b22 += 2; c11 += 1; c33 += 1;}
            if (c3 != 9 && c3 == z) { c33 = -9; a11 += 1; a33 += 1; b22 += 2; b33 += 2; c11 += 1; c22 += 2; }
            //flipFlop
            if (z == 100) { z = -100; } else { z = 100; }

            if (a1 != 1 && a1 == z) { a11 = -20; a22 += 0.5; a33 += 0.5; b11 += 0.5; b22 += 0.5; c11 += 0.5; c33 += 0.5; }
            if (a2 != 2 && a2 == z) { a22 = -20; a11 += 0.5; a33 += 0.5; b22 += 0.5; c22 += 0.5; }
            if (a3 != 3 && a3 == z) { a33 = -20; a11 += 0.5; a22 += 0.5; b22 += 0.5; b33 += 0.5; c11 += 0.5; c33 += 0.5; }

            if (b1 != 4 && b1 == z) { b11 = -20; a11 += 0.5; b22 += 0.5; b33 += 0.5; c11 += 0.5; }
            if (b2 != 5 && b2 == z) { b22 = -20; }
            if (b3 != 6 && b3 == z) { b33 = -20; a33 += 0.5; b11 += 0.5; b22 += 0.5; c33 += 0.5; }

            if (c1 != 7 && c1 == z) { c11 = -20; a11 += 0.5; a33 += 0.5; b11 += 0.5; b22 += 0.5; c22 += 0.5; c33 += 0.5; }
            if (c2 != 8 && c2 == z) { c22 = -20; a22 += 0.5; b22 += 0.5; c11 += 0.5; c33 += 0.5; }
            if (c3 != 9 && c3 == z) { c33 = -20; a11 += 0.5; a33 += 0.5; b22 += 0.5; b33 += 0.5; c11 += 0.5; c22 += 0.5; }

            //fliter

            if (a11 >= a11 && a11 >= a22 && a11 >= a33 && a11 >= b11 && a11 >= b22 && a11 >= b33 && a11 >= c11 && a11 >= c22 && a11 >= c33) {a41 = 1; }
            if (a22 >= a11 && a22 >= a22 && a22 >= a33 && a22 >= b11 && a22 >= b22 && a22 >= b33 && a22 >= c11 && a22 >= c22 && a22 >= c33) {a42 = 1; }
            if (a33 >= a11 && a33 >= a22 && a33 >= a33 && a33 >= b11 && a33 >= b22 && a33 >= b33 && a33 >= c11 && a33 >= c22 && a33 >= c33) {a43 = 1; }
            if (b11 >= a11 && b11 >= a22 && b11 >= a33 && b11 >= b11 && b11 >= b22 && b11 >= b33 && b11 >= c11 && b11 >= c22 && b11 >= c33) {b41 = 1; }
            if (b22 >= a11 && b22 >= a22 && b22 >= a33 && b22 >= b11 && b22 >= b22 && b22 >= b33 && b22 >= c11 && b22 >= c22 && b22 >= c33) {b42 = 1; }
            if (b33 >= a11 && b33 >= a22 && b33 >= a33 && b33 >= b11 && b33 >= b22 && b33 >= b33 && b33 >= c11 && b33 >= c22 && b33 >= c33) {b43 = 1; }
            if (c11 >= a11 && c11 >= a22 && c11 >= a33 && c11 >= b11 && c11 >= b22 && c11 >= b33 && c11 >= c11 && c11 >= c22 && c11 >= c33) {c41 = 1; }
            if (c22 >= a11 && c22 >= a22 && c22 >= a33 && c22 >= b11 && c22 >= b22 && c22 >= b33 && c22 >= c11 && c22 >= c22 && c22 >= c33) {c42 = 1; }
            if (c33 >= a11 && c33 >= a22 && c33 >= a33 && c33 >= b11 && c33 >= b22 && c33 >= b33 && c33 >= c11 && c33 >= c22 && c33 >= c33) {c43 = 1; }

            //finalizer

            
        aiRndm:
            Random numgen = new Random();
            int x = numgen.Next(1, 10);
            if(u == 100000) { Console.WriteLine("Its a draw!"); goto finish; }
            u++;
            switch (x)
            {
                case 1: { if (a41 == 1 && a1 == 1) { a1 = z; } else { goto aiRndm; } break; }
                case 2: { if (a42 == 1 && a2 == 2) { a2 = z; } else { goto aiRndm; } break; }
                case 3: { if (a43 == 1 && a3 == 3) { a3 = z; } else { goto aiRndm; } break; }

                case 4: { if (b41 == 1 && b1 == 4) { b1 = z; } else { goto aiRndm; } break; }
                case 5: { if (b42 == 1 && b2 == 5) { b2 = z; } else { goto aiRndm; } break; }
                case 6: { if (b43 == 1 && b3 == 6) { b3 = z; } else { goto aiRndm; } break; }

                case 7: { if (c41 == 1 && c1 == 7) { c1 = z; } else { goto aiRndm; } break; }
                case 8: { if (c42 == 1 && c2 == 8) { c2 = z; } else { goto aiRndm; } break; }
                case 9: { if (c43 == 1 && c3 == 9) { c3 = z; } else { goto aiRndm; } break; }
            }
            //winChecker
            if (a1 < -50 && a2 < -50 && a3 < -50) { Console.WriteLine("O Wins!"); goto finish; }
            if (b1 < -50 && b2 < -50 && b3 < -50) { Console.WriteLine("O Wins!"); goto finish; }
            if (c1 < -50 && c2 < -50 && c3 < -50) { Console.WriteLine("O Wins!"); goto finish; }

            if (a1 < -50 && b1 < -50 && c1 < -50) { Console.WriteLine("O Wins!"); goto finish; }
            if (a2 < -50 && b2 < -50 && c2 < -50) { Console.WriteLine("O Wins!"); goto finish; }
            if (a3 < -50 && b3 < -50 && c3 < -50) { Console.WriteLine("O Wins!"); goto finish; }

            if (a1 < -50 && b2 < -50 && c3 < -50) { Console.WriteLine("O Wins!"); goto finish; }
            if (a3 < -50 && b2 < -50 && c1 < -50) { Console.WriteLine("O Wins!"); goto finish; }


            if (a1 > 50 && a2 > 50 && a3 > 50) { Console.WriteLine("X Wins!"); goto finish; }
            if (b1 > 50 && b2 > 50 && b3 > 50) { Console.WriteLine("X Wins!"); goto finish; }
            if (c1 > 50 && c2 > 50 && c3 > 50) { Console.WriteLine("X Wins!"); goto finish; }

            if (a1 > 50 && b1 > 50 && c1 > 50) { Console.WriteLine("X Wins!"); goto finish; }
            if (a2 > 50 && b2 > 50 && c2 > 50) { Console.WriteLine("X Wins!"); goto finish; }
            if (a3 > 50 && b3 > 50 && c3 > 50) { Console.WriteLine("X Wins!"); goto finish; }

            if (a1 > 50 && b2 > 50 && c3 > 50) { Console.WriteLine("X Wins!"); goto finish; }
            if (a3 > 50 && b2 > 50 && c1 > 50) { Console.WriteLine("X Wins!"); goto finish; }


            goto start;
        finish:
            Console.ReadKey();
        }
    }
}
