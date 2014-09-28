//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.


using System;

class PrintCards
{
    static void Main()
    {
        string cardColor = "";
        string cardName = "";
        string card = "";

        Console.WriteLine("All the cards in a deck : ");
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 13; j++)
            {
                switch (j)
                {
                    case 1: cardName = "ACE"; break;
                    case 2: cardName = "TWO"; break; 
                    case 3: cardName = "THREE"; break;
                    case 4: cardName = "FOUR"; break;
                    case 5: cardName = "FIVE"; break;
                    case 6: cardName = "SIX"; break;
                    case 7: cardName = "SEVEN"; break;
                    case 8: cardName = "EIGHT"; break;
                    case 9: cardName = "NINE"; break;
                    case 10: cardName = "TEN"; break;
                    case 11: cardName = "KING"; break;
                    case 12: cardName = "QUEEN"; break;
                    case 13: cardName = "JACK"; break;
                    default: Console.WriteLine("error"); break;
                }
                switch (i)
                {
                    case 1: cardColor = "Spades ♠"; break;
                    case 2: cardColor = "Diamonds ♦"; break;
                    case 3: cardColor = "Hearts ♥"; break;
                    case 4: cardColor = "Clubs ♣"; break;
                    default: Console.WriteLine("error"); break;
                }
                card = cardName + " " + cardColor;
                Console.WriteLine(card);

               
            }
        }
    }
}
