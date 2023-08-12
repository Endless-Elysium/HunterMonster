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
            Player.MyArmor.chestPlate = EquipmentListClass.ChestPlates[1];
            Player.MyArmor.helmet = EquipmentListClass.Helmets[1];
            Console.WriteLine(Player.MyWeapon.Name);
            Console.WriteLine(Player.MyArmor.helmet.Name);
            Console.WriteLine(Player.MyArmor.chestPlate.Name);
            Console.WriteLine(Player.MyArmor.helmet.PhysDef);
            Console.WriteLine(Player.MyArmor.chestPlate.PhysDef);
            Console.WriteLine(Player.MyArmor.ArmorphysDef);
            Console.WriteLine(Player.PhysDef);
            Player.MyArmor.chestPlate = EquipmentListClass.ChestPlates[0];
            Player.MyArmor.helmet = EquipmentListClass.Helmets[0];
            Console.WriteLine(Player.MyWeapon.Name);
            Console.WriteLine(Player.MyArmor.helmet.Name);
            Console.WriteLine(Player.MyArmor.chestPlate.Name);
            Console.WriteLine(Player.MyArmor.helmet.PhysDef);
            Console.WriteLine(Player.MyArmor.chestPlate.PhysDef);
            Console.WriteLine(Player.MyArmor.ArmorphysDef);
            Console.WriteLine(Player.PhysDef);
            Ui.DrawWeaponCraft();
        }
    }
}