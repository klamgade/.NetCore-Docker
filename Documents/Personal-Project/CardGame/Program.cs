using System;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deckOne = new Deck();
            deckOne.Shuffle();
            for(int i = 0; i < 52; i++)
            {
                Console.Write("{0, -19}", deckOne.DealCard().ToString());
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
