using Fighters.Factory;
using Fighters.Models.Fighters;

namespace Fighters.GameManagement;

public class GameManager : IGameManager
{
    private readonly IFightersFactory _fightersFactory;

    public GameManager( IFightersFactory fightersFactory )
    {
        _fightersFactory = fightersFactory;
    }
    public void Play()
    {
        PrintMenu();

        bool IsPlay = true;

        while ( IsPlay )
        {
            Console.Write( "Введите команду: " );
            string command = Console.ReadLine();
            switch ( command )
            {
                case "new fighter":
                    NewFighter();
                    break;
                case "show fighters":
                    ShowFighters();
                    break;
                case "fight":
                    Fight();
                    break;
                case "exit":
                    IsPlay = false;
                    Console.WriteLine( "Спасибо за игру" );
                    break;
                default:
                    Console.WriteLine( "Неизвестная команда" );
                    break;
            }
        }
    }

    private void PrintMenu()
    {
        Console.WriteLine( "FIGHTERS" );
        Console.WriteLine( "Команды: " );
        Console.WriteLine( "new fighter - добавить бойца на арену" );
        Console.WriteLine( "show fighters - показать всех добавленных бойцов" );
        Console.WriteLine( "fight - начать битву" );
        Console.WriteLine( "exit - выйти из игры" );
    }

    private void NewFighter()
    {
        IFighter fighter = _fightersFactory.CreateFighter();
        Console.WriteLine( $"Боец {fighter.Name} создан" );
    }

    private void ShowFighters()
    {
        List<IFighter> fighters = _fightersFactory.GetFighters();

        if ( fighters.Count == 0 )
        {
            Console.WriteLine( "Список пуст." );
            return;
        }

        Console.WriteLine( "Список бойцов\n" );
        foreach ( IFighter fighter in fighters )
        {
            Console.WriteLine( fighter + "\n" );
        }
    }

    private void Fight()
    {
        int round = 0;
        List<IFighter> fighters = _fightersFactory.GetFighters();
        int fightersSum = fighters.Count;
        if ( fightersSum < 2 )
        {
            Console.WriteLine( $"Недостаточное количество бойцов. Добавьте еще хотя бы {2 - fightersSum} бойцов." );
            return;
        }

        Console.WriteLine( "Бой!" );

        while ( fighters.Count( f => f.IsAlive ) > 1 )
        {
            Console.WriteLine( $"Раунд {++round}" );

            fighters = fighters.OrderBy( f => Random.Shared.Next() ).ToList();

            foreach ( IFighter fighter in fighters )
            {
                if ( !fighter.IsAlive )
                {
                    continue;
                }

                IFighter opponent = fighters.Where( f => f != fighter && f.IsAlive ).OrderBy( f => Random.Shared.Next() ).First();
                Attack( fighter, opponent );
            }

            ShowFighters();

            Console.WriteLine( "Нажмите Enter для продолжения." );
            while ( Console.ReadKey().Key != ConsoleKey.Enter )
            { }

        }

        IFighter winner = fighters.FirstOrDefault( f => f.IsAlive );

        Console.WriteLine( $"Победитель - {winner.Name}" );
    }

    private void Attack( IFighter fighter, IFighter opponent )
    {
        int damage = fighter.CalculateDamage();
        opponent.TakeDamage( damage );
        Console.WriteLine( $"{fighter.Name} атакует {opponent.Name} и наносит урон {damage}. {opponent.Name} {( opponent.IsAlive ? "выживает" : "погибает" )}" );
    }

}