using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Cars;
using CarFactory.CarService;

namespace CarFactory.FactoryManagment;
public class FactoryManager : IFactoryManager
{
    private readonly ICarAssembly _carAssembly;
    public FactoryManager( ICarAssembly carAssembly )
    {
        _carAssembly = carAssembly;
    }
    public void Run()
    {
        PrintName();
        bool IsEnd = false;

        while ( !IsEnd )
        {
            PrintMenu();
            string command = Console.ReadLine();
            switch ( command )
            {
                case "create car":
                    CreateCar();
                    break;
                case "exit":
                    IsEnd = true;
                    break;
                default:
                    Console.WriteLine( "Неизвестная команда" );
                    break;
            }
        }
    }

    private void PrintName()
    {
        Console.WriteLine( "### CAR FACTORY ###" );
    }
    private void PrintMenu()
    {
        Console.Write( "Выберите команду:\ncreate car - создать автомобиль\nexit - выйти\n>" );
    }

    private void CreateCar()
    {
        ICar car = _carAssembly.AssemblingCar();
        Console.WriteLine( car );
    }
}
