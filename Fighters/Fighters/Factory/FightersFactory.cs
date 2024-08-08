using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Fighters.Models.Armors;
using Fighters.Models.Fighters;
using Fighters.Models.FightersClasses;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Factory;
public class FightersFactory : IFightersFactory
{
    private readonly List<IFighter> _fighters = new List<IFighter>();

    public IFighter CreateFighter()
    {
        string name = GetName();
        IFightersClass fighterClass = GetFightersClass();
        IRace race = GetRace();
        IWeapon weapon = GetWeapon();
        IArmor armor = GetArmor();
        IFighter fighter = new Fighter( name, fighterClass, race, weapon, armor );

        _fighters.Add( fighter );

        return fighter;
    }

    public List<IFighter> GetFighters() => _fighters.ToList();

    private string GetName()
    {
        Console.Write( "Введите имя для бойца: " );
        string str = Console.ReadLine();
        while ( string.IsNullOrEmpty( str ) )
        {
            Console.Write( "Пожалуйста, введите имя: " );
            str = Console.ReadLine();
        }
        return str;
    }

    private IFightersClass GetFightersClass()
    {
        bool IsSelectClass = false;
        IFightersClass fighterClass = null;
        while ( !IsSelectClass )
        {
            IsSelectClass = true;
            Console.Write( "Выберите персонажа:\nрыцарь\nлегионер\nдружинник\n>" );
            string fClassStr = Console.ReadLine();
            switch ( fClassStr )
            {
                case "рыцарь":
                    fighterClass = new Knight();
                    break;
                case "легионер":
                    fighterClass = new Legionnaire();
                    break;
                case "дружинник":
                    fighterClass = new Vigilante();
                    break;
                default:
                    Console.WriteLine( "Неизвестный класс. Выберите один из предложенных." );
                    IsSelectClass = false;
                    break;
            }
        }
        return fighterClass;
    }

    private IRace GetRace()
    {
        bool IsSelectRace = false;
        IRace race = null;
        while ( !IsSelectRace )
        {
            IsSelectRace = true;
            Console.Write( "Выберите расу персонажа:\nчеловек\nэльф\nгном\nгоблин\n>" );
            string raceStr = Console.ReadLine();
            switch ( raceStr )
            {
                case "человек":
                    race = new Human();
                    break;
                case "эльф":
                    race = new Elf();
                    break;
                case "гном":
                    race = new Dwarf();
                    break;
                case "гоблин":
                    race = new Goblin();
                    break;
                default:
                    Console.WriteLine( "Неизвестная раса. Выберите одну из предложенных." );
                    IsSelectRace = false;
                    break;
            }
        }
        return race;
    }

    private IWeapon GetWeapon()
    {
        bool IsSelectWeapon = false;
        IWeapon weapon = null;
        while ( !IsSelectWeapon )
        {
            IsSelectWeapon = true;
            Console.Write( "Выберите оружие:\nкулаки\nкинжал\nмеч\nтомагавк\n>" );
            string weaponStr = Console.ReadLine();
            switch ( weaponStr )
            {
                case "кулаки":
                    weapon = new Fists();
                    break;
                case "кинжал":
                    weapon = new Dagger();
                    break;
                case "меч":
                    weapon = new Sword();
                    break;
                case "томагавк":
                    weapon = new Tomahawk();
                    break;
                default:
                    Console.WriteLine( "Неизвестное оружие. Выберите одно из предложенных." );
                    IsSelectWeapon = false;
                    break;
            }
        }
        return weapon;
    }

    private IArmor GetArmor()
    {
        bool IsSelectArmor = false;
        IArmor armor = null;
        while ( !IsSelectArmor )
        {
            IsSelectArmor = true;
            Console.Write( "Выберите броню:\nбез брони\nкожаная броня\nкольчуга\n>" );
            string armorStr = Console.ReadLine();
            switch ( armorStr )
            {
                case "без брони":
                    armor = new NoArmor();
                    break;
                case "кожаная броня":
                    armor = new LeatherArmor();
                    break;
                case "кольчуга":
                    armor = new Hauberk();
                    break;
                default:
                    Console.WriteLine( "Неизвестная броня. Выберите одну из предложенных." );
                    IsSelectArmor = false;
                    break;
            }
        }

        return armor;
    }

}
