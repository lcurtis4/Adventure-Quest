using System;

namespace Quest 
{
    public class Prize
    {
        private string _text {get; set;}

        public Prize ( string text )
        {
            _text = text;
        }

        public void ShowPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0 )
            {
                Console.WriteLine(_text);
            }
            else 
            {
                Console.WriteLine("Yikes, did you even try?"); 
            }
        }
    }
}