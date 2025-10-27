//make the ability to create flashcards with a front and back side
//flash cards should be saved to a file
//each card is a class stored in a list
//ability to add, remove, and edit cards
//ability to quiz yourself on the cards
//ability to shuffle the cards
//use the front or back of the card to quiz

namespace FlashCards
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}