using System;
using System.Threading;

class Program
{
    static void Main()
    {
        
        int positionX = 2; 
        int positionY = 10;
        string paddle = "\u2503";
        
        
        int P2X = Console.WindowWidth - 3;
        int P2Y = 10;
        string paddle1 = "\u2503"; 
        
        
        int paddleLength = 4; 

        
        int ballX = Console.WindowWidth / 2;
        int ballY = Console.WindowHeight / 2;
        int ballSpeedX = 1;
        int ballSpeedY = 1;
        string ball = "O";

        
        Console.CursorVisible = false;

        while (true)
        {
            
            Console.Clear();

            
            for (int i = 0; i < paddleLength; i++)
            {
                Console.SetCursorPosition(positionX, positionY + i);
                Console.Write(paddle);
            }

            
            for (int i = 0; i < paddleLength; i++)
            {
                Console.SetCursorPosition(P2X, P2Y + i);
                Console.Write(paddle1);
            }

            
            Console.SetCursorPosition(ballX, ballY);
            Console.Write(ball);

            
            ballX += ballSpeedX;
            ballY += ballSpeedY;

            
            if (ballY <= 0 || ballY >= Console.WindowHeight - 1)
            {
                ballSpeedY = -ballSpeedY;
            }

            
            if (ballX == positionX + 1 && ballY >= positionY && ballY < positionY + paddleLength)
            {
                ballSpeedX = -ballSpeedX;
            }
            else if (ballX == P2X - 1 && ballY >= P2Y && ballY < P2Y + paddleLength)
            {
                ballSpeedX = -ballSpeedX;
            }

            
            if (ballX <= 0 || ballX >= Console.WindowWidth - 1)
            {
                ballX = Console.WindowWidth / 2;
                ballY = Console.WindowHeight / 2;
                ballSpeedX = -ballSpeedX;
            }

            
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true);

                
                if (key.Key == ConsoleKey.W && positionY > 0)
                {
                    positionY--; 
                }
                else if (key.Key == ConsoleKey.S && positionY < Console.WindowHeight - paddleLength)
                {
                    positionY++; 
                }

                
                if (key.Key == ConsoleKey.UpArrow && P2Y > 0)
                {
                    P2Y--; 
                }
                else if (key.Key == ConsoleKey.DownArrow && P2Y < Console.WindowHeight - paddleLength)
                {
                    P2Y++; 
                }
            }

            
            Thread.Sleep(50);
        }
    }
}
