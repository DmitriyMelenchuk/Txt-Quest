namespace TxtQuestJustMoby
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            Rooms rooms = new Rooms("Таверна", new Characters("Бродяга"));
            rooms.ActionRoom();



        }
    }
}
