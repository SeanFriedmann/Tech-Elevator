using System;
using DeckOfCards.Stubs;
using System.Drawing; //color addition

 //allows you to use deckofcards(project) .stubs (folder)
//known as a convention
namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WoodenPencil pencil = new WoodenPencil();
            pencil.Length = 5.0;
            //cannot change const or static readonly in Main


        }
    }
}
