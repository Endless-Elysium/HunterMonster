using HunterMonster.Equipment;
namespace HunterMonster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hunter Player = new Hunter();

            while (true)
            {
                Ui.DrawMainMenu();
                int input = Ui.IntPlayerInput();
                switch (input)
                {
                    case 0:
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:
                        Player = Forge.ForgeEquipment(Player);
                        break;
                }
            }
        }
    }
}