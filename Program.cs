using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int player1X = 2;
        int player1Y = 10;
        string paddleSymbol = "\u2503";
        
        int player2X = Console.WindowWidth - 3;
        int player2Y = 10;
        
        int paddleLength = 4;

        int ballX = Console.WindowWidth / 2;
        int ballY = Console.WindowHeight / 2;
        int ballSpeedX = 1;
        int ballSpeedY = 1;
        string ballSymbol = "O";

        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            
            PaintPaddle(player1X, player1Y, paddleLength, paddleSymbol);
            PaintPaddle(player2X, player2Y, paddleLength, paddleSymbol);
            
            Console.SetCursorPosition(ballX, ballY);
            Console.Write(ballSymbol);
            
            ballX += ballSpeedX;
            ballY += ballSpeedY;
            
            if (ballY <= 0 || ballY >= Console.WindowHeight - 1)
            {
                ballSpeedY = -ballSpeedY;
            }
            
            if (ballX == player1X + 1 && ballY >= player1Y && ballY < player1Y + paddleLength)
            {
                ballSpeedX = -ballSpeedX;
            }
            else if (ballX == player2X - 1 && ballY >= player2Y && ballY < player2Y + paddleLength)
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
                
                if (key.Key == ConsoleKey.W && player1Y > 0)
                {
                    player1Y--;
                }
                else if (key.Key == ConsoleKey.S && player1Y < Console.WindowHeight - paddleLength)
                {
                    player1Y++;
                }

                // Spieler 2 steuern
                if (key.Key == ConsoleKey.UpArrow && player2Y > 0)
                {
                    player2Y--;
                }
                else if (key.Key == ConsoleKey.DownArrow && player2Y < Console.WindowHeight - paddleLength)
                {
                    player2Y++;
                }
            }
            
            Thread.Sleep(75);
        }
    }
    static void PaintPaddle(int x, int y, int length, string symbol)
    {
        for (int i = 0; i < length; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write(symbol);
        }
    }
}

