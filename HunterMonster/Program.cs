using HunterMonster.Equipment;
using HunterMonster_Combat;
namespace HunterMonster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hunter MC = new Hunter();

            while (true)
            {
                Ui.DrawMainMenu();
                int input = Ui.IntPlayerInput();
                switch (input)
                {
                    case 0:
                    case 1:
                        Ui.DrawStats(MC);
                        break;
                    case 2:
                        Ui.DrawMonsterList();
                        input = Ui.IntPlayerInput();
                        Hunting.Begin(input,MC);
                        MC.Update();
                        break;
                    case 3:
                        MC = Forge.ForgeEquipment(MC);
                        break;
                }
            }
        }
    }
}