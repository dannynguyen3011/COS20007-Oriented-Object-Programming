namespace firstProgram { 
class Tank
{
    string color;
    int X, Y;   

    public void SetColor(string input_color) { color = input_color; }
    string GetColor() { return color; }
    public void SetX(int input_X) { X = input_X; }
    int GetX() { return X; }
    public void SetY(int input_Y) { Y = input_Y; }
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
            Console.WriteLine("Current position of Player 1: " + Player1.GetX().ToString() + "-" + Player1.GetY().ToString());
        }
    }
}
}