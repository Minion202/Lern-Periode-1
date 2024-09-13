using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //Player 1
        int positionX = 2; 
        int positionY = 10;
        string paddle = "\u2503";
        
        // Player 2
        int P2X = Console.WindowWidth - 3;
        int P2Y = 10;
        string paddle1 = "\u2503"; 
        
        // Paddle 
        int paddleLength = 2; 

        // To stop the paddle to flicker
        Console.CursorVisible = false;

        while (true)
        {
            // To clear the console everytime a goal is shot 
            Console.Clear();

            //Player1 paddle
            for (int i = 0; i < paddleLength; i++)
            {
                Console.SetCursorPosition(positionX, positionY + i);
                Console.Write(paddle);
            }

            //Player2 paddle
            for (int i = 0; i < paddleLength; i++)
            {
                Console.SetCursorPosition(P2X, P2Y + i);
                Console.Write(paddle1);
            }

            // Check if a key has been pressed
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true); // Get the pressed key without displaying it

                // Player1 controls 
                if (key.Key == ConsoleKey.W)
                {
                    if (positionY > 0) 
                    {
                        positionY--; 
                    }
                }
                else if (key.Key == ConsoleKey.S)
                {
                    if (positionY < Console.WindowHeight - paddleLength) 
                    {
                        positionY++; 
                    }
                }

                // Player2 controls 
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (P2Y > 0) 
                    {
                        P2Y--; 
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (P2Y < Console.WindowHeight - paddleLength) 
                    {
                        P2Y++; 
                    }
                }
            }

            
            Thread.Sleep(20);
        }
    }
}
