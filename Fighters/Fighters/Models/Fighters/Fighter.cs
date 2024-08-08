using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighters.Models.Armors;
using Fighters.Models.FightersClasses;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters;
public class Fighter : IFighter
{
    public string Name { get; }
    public IFightersClass FightersClass { get; }
    public IRace Race { get; }
    public IWeapon Weapon { get; }
    public IArmor Armor { get; }
    public int CurrentHealth { get; private set; }
    public int ArmorPoints { get; private set; }
    public int MaxHealth { get; }
    public int AverageDamage => Race.Damage + FightersClass.Damage + Weapon.Damage;
    public bool IsAlive => CurrentHealth > 0;

    public Fighter(
       string name,
       IFightersClass fightersClass,
       IRace race,
       IWeapon weapon,
       IArmor armor )
    {
        Name = name;
        FightersClass = fightersClass;
        Race = race;
        Weapon = weapon;
        Armor = armor;
        ArmorPoints = Race.Armor + Armor.Armor;
        MaxHealth = Race.Health + FightersClass.Health + ArmorPoints;
        CurrentHealth = MaxHealth;
    }

    public int CalculateDamage()
    {
        Random rnd = new Random();
        const int DamageRejectionPercent = 25;
        const int CritPercentChance = 20;

        double attackMultiplier = 1 + ( double )rnd.Next( -DamageRejectionPercent, DamageRejectionPercent ) / 100;
        int fighterDamage = ( int )( AverageDamage * attackMultiplier );

        bool isCriticalAttack = Random.Shared.Next( 1, 101 ) < CritPercentChance;

        if ( isCriticalAttack )
        {
            fighterDamage *= 2;
        }

        return fighterDamage;
    }

    public void TakeDamage( int damage )
    {
        CurrentHealth = Math.Max( CurrentHealth - damage, 0 );
    }

    public override string ToString()
    {
        return $"Боец {Name}: \n" +
            $"Класс: {FightersClass.Name} \n" +
            $"Раса: {Race.Name} \n" +
            $"Оружие: {Weapon.Name} \n" +
            $"Броня: {Armor.Name} \n" +
            $"Максимальное здоровье: {MaxHealth} \n" +
            $"Текущее здоровье: {CurrentHealth} \n" +
            $"Количество брони: {ArmorPoints} \n" +
            $"Урон: {AverageDamage} \n" +
            $"Состояние здоровья: {( IsAlive ? "Жив" : "Мертв" )}";
    }
}
