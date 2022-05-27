using System;

namespace TxtQuestJustMoby
{
    class Rooms : IDialogs
    {
        Characters _characters;
        private string _titleRoom;

        public Rooms(string titleRoom, Characters character)
        {
            _titleRoom = titleRoom;
            _characters = character;
        }

        public void ActionRoom()
        {
            Dialogs();
        }

        public void Dialogs()
        {
            while (true)
            {
                int inputUser;

                Console.WriteLine($"1. Поговорить с {_characters.name}.");
                Console.WriteLine("2. Осмотреть окрестности.");
                inputUser = Convert.ToInt32(Console.ReadLine());

                if (inputUser == 1)
                {
                    _characters.Dialogs();
                }
                else if (inputUser == 2)
                {
                    Console.WriteLine($"Вы осматриваете {_titleRoom}:");
                    ActionRoom();
                }

                Console.WriteLine("1.Забрать все что у него есть.");
                Console.WriteLine("2.Оставить бродягу в покое.");
                inputUser = Convert.ToInt32(Console.ReadLine());

                if (inputUser == 1)
                {
                    if (_characters.Item == true)
                    {
                        Console.WriteLine(" - Я теперь умру с голоду.");
                        Console.WriteLine($"{_characters.name} отдаёт вам 50 монет и Медальон.\n");
                        _characters.Item = false;
                    }
                    else if (_characters.Item == false)
                    {
                        Console.WriteLine(" - У меня больше ничего нет.\n");
                    }
                }
                else if (inputUser == 2)
                {
                    Console.WriteLine($"{_characters.name} всадил Вам нож в спину как только Вы отвернулись");
                    Environment.Exit(0);
                }
            }

        }
    }
}
