﻿Console.WriteLine("Please the number. Seven attempts");

GameMelody();


void GameMelody()
{
    Random myRandom = new Random();
    int randomNumber = myRandom.Next(1, 100);
    
    for (int i = 0; i < 7; i++)
    {
        int numbar = int.Parse(Console.ReadLine());
        if (randomNumber == numbar)
        {
            Console.WriteLine("Victory");      
        }
        else if (numbar != randomNumber)
        {
            if (randomNumber < numbar)
            {
                Console.WriteLine($" The figure is less {numbar} ");
            }
            else if (randomNumber > numbar)
            {
                Console.WriteLine($" This figure is bigger {numbar} ");
            }
        }
    }
    Console.WriteLine("Game over");
}
