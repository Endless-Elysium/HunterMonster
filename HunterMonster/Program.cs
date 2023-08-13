using HunterMonster.Equipment;
namespace HunterMonster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hunter Player = new Hunter();
            Console.WriteLine(Player.MyArmor.helmet.Name);
            Console.WriteLine(Player.MyArmor.chestPlate.Name);
            Console.WriteLine(Player.MyWeapon.Name);
            Console.WriteLine(Player.MyArmor.helmet.Name);
            Console.WriteLine(Player.MyArmor.chestPlate.Name);
            Console.WriteLine(Player.MyArmor.helmet.PhysDef);
            Console.WriteLine(Player.MyArmor.chestPlate.PhysDef);
            Console.WriteLine(Player.MyArmor.ArmorphysDef);
            Console.WriteLine(Player.PhysDef);
            Player = Forge.ForgeEquipment(Player);
            Console.WriteLine(Player.MyWeapon.Name);
            Console.WriteLine(Player.MyWeapon.PhysDamage);
            Console.WriteLine(Player.MyWeapon.Speed);
            Console.WriteLine(Player.MyArmor.helmet.Name);
            Console.WriteLine(Player.MyArmor.chestPlate.Name);
            Console.WriteLine(Player.MyWeapon.Name);
            Console.WriteLine(Player.MyArmor.helmet.Name);
            Console.WriteLine(Player.MyArmor.chestPlate.Name);
            Console.WriteLine(Player.MyArmor.helmet.PhysDef);
            Console.WriteLine(Player.MyArmor.chestPlate.PhysDef);
            Console.WriteLine(Player.MyArmor.ArmorphysDef);
            Console.WriteLine(Player.PhysDef);

        }
    }
}