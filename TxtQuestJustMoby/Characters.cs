using System;

namespace TxtQuestJustMoby
{
    class Characters : IDialogs
    {
        private string _nameCharacter;
        bool item = true;

        public Characters(string nameCharacter)
        {
            _nameCharacter = nameCharacter;
        }

        public string name { get => _nameCharacter; set => _nameCharacter = value; }
        public bool Item { get => item; set => item = value; }

        public void Dialogs()
        {
            if (Item == true)
            {
                Console.WriteLine(" - Жизнь или смерть, грязный бродяга!");
                Console.WriteLine(" - Вот возьми всё что у меня есть, только не трогай меня\n");
            }

            else if (item == false)
            {
                Console.WriteLine(" - Жизнь или смерть, грязный бродяга!\n");

            }
        }
    }
}
