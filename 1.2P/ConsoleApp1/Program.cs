using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message myMessage;
            myMessage = new Message("Hello World - from Message Object");
            myMessage.Print();

            Message[] messages = new Message[5];
            messages[0] = new Message("Welcome back!");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("Oh hi!");
            messages[4] = new Message("That is a silly name");

            Console.WriteLine("Enter name:");

            String name = Console.ReadLine().ToLower();


            if (name == "mark")
            {
                messages[0].Print();
            }
            else if (name == "danny")
            {
                messages[1].Print();
            }
            else if (name == "wilma")
            {
                messages[2].Print();
            }
            else if (name == "alice")
            {
                messages[3].Print();
            }
            else
            {
                messages[4].Print();
            }
            Console.ReadLine(); }

            class Tank
            {
            string color;
            int X, Y;

            public void SetColor(string input_color) { color = input_color; }
            string GetColor() { return color; }
            public void SetX(int input_X) { X = input_X; }
            int GetX() { return X; }
            public void SetY(int input_Y) {  Y = input_Y; }
            int GetY() { return Y; } 
            class Program
            {
                static void Main(string[] args)
                {
                    Tank Player1 = new Tank();
                    Player1.SetColor("green");
                    Player1.SetX(400);
                    Player1.SetY(400);

                    Tank Player2 = new Tank();
                    Player2.SetColor("yellow");
                    Player2.SetX(200);
                    Player2.SetY(200);

                    Tank V1 = new Tank();
                    V1.SetColor("White");
                    V1.SetX(350);
                    V1.SetY(0);

                    Tank V2 = new Tank();
                    V2.SetColor("White");
                    V2.SetX(450);
                    V2.SetY(0);

                    Console.WriteLine("First position of Player 1:" + Player1.GetX().ToString() + "-" + Player1.GetY().ToString());
                    Console.ReadKey();
                    Console.WriteLine("Move to new position");
                    Player1.SetX(400);
                    Player1.SetY(250);
                    Console.WriteLine("Current position of Player 1: " + );
                }
            }
        }
    }
}
