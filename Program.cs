using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Initial position of the emoji
        //Player 1
        int positionX = 0;
        int positionY = 0;
        string emoji = "\u2503";
        
        // Player 2
        int P2X = 50;
        int P2Y = 0;
        string emoji1 = "\u2503"; // The emoji character to display
        
        // The emoji character to display
        // Hide the cursor to prevent flickering
        Console.CursorVisible = false;
        
        while (true)
        {
            // Clear the console and draw the emoji at the current position
            Console.Clear();
            Console.SetCursorPosition(positionX, positionY); // Set the position on the console
            Console.Write(emoji); // Draw the emoji
            
            // Clear the console and draw the emoji at the current position
            Console.Clear();
            Console.SetCursorPosition(P2X, P2Y); // Set the position on the console
            Console.Write(emoji1); // Draw the emoji
        
            // Check if a key has been pressed
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true); // Get the pressed key without displaying it

                // Move right if 'D' is pressed
                if (key.Key == ConsoleKey.D)
                {
                    positionX++; // Move the emoji to the right
                }
                // Move left if 'A' is pressed
                else if (key.Key == ConsoleKey.A)
                {
                    if (positionX > 0) // Ensure the position doesn't go negative
                    {
                        positionX--; // Move the emoji to the left
                    }
                }
                // Move up if 'W' is pressed
                else if (key.Key == ConsoleKey.W)
                {
                    if (positionY > 0) // Ensure the position doesn't go negative
                    {
                        positionY--; // Move the emoji up
                    }
                }
                // Move down if 'S' is pressed
                else if (key.Key == ConsoleKey.S)
                {
                    if (positionY < Console.WindowHeight - 1) // Ensure the position doesn't exceed the console height
                    {
                        positionY++; // Move the emoji down
                    }
                }
                // Move right if 'RightArrow' is pressed
                if (key.Key == ConsoleKey.RightArrow)
                {
                    P2X++; // Move the emoji to the right
                }
                // Move left if 'LeftAarrow' is pressed
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (P2X > 0) // Ensure the position doesn't go negative
                    {
                        P2X--; // Move the emoji to the left
                    }
                }
                // Move up if 'UpArrow' is pressed
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (P2Y > 0) // Ensure the position doesn't go negative
                    {
                        P2Y--; // Move the emoji up
                    }
                }
                // Move down if 'DownArrow' is pressed
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (P2Y < Console.WindowHeight - 1) // Ensure the position doesn't exceed the console height
                    {
                        P2Y++; // Move the emoji down
                    }
                }
            }

                    // Add a small delay to control the speed
                    Thread.Sleep(20);
                }
            }
        }
