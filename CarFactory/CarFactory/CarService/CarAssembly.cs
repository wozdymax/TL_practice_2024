using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Cars;
using CarFactory.Configurations.Bodies;
using CarFactory.Configurations.Brands;
using CarFactory.Configurations.Colors;
using CarFactory.Configurations.Engines;
using CarFactory.Configurations.Transmissions;
using static System.Formats.Asn1.AsnWriter;

namespace CarFactory.CarService;
public class CarAssembly : ICarAssembly
{
    public ICar AssemblingCar()
    {
        IBrand brand = GetBrand();
        IBody body = GetBody();
        IColor color = GetColor();
        IEngine engine = GetEngine();
        ITransmission transmission = GetTransmission();
        ICar car = new Car( brand, body, color, engine, transmission );

        return car;
    }

    private IBrand GetBrand()
    {
        bool IsSelectBrend = false;
        IBrand brand = null;
        while ( !IsSelectBrend )
        {
            IsSelectBrend = true;
            Console.Write( "Выберите марку:\nфорд\nшкода\nфольксваген\nауди\n>" );
            string brandStr = Console.ReadLine();
            switch ( brandStr )
            {
                case "форд":
                    brand = new Ford();
                    break;
                case "шкода":
                    brand = new Skoda();
                    break;
                case "фольксваген":
                    brand = new Volkswagen();
                    break;
                case "ауди":
                    brand = new Audi();
                    break;
                default:
                    Console.WriteLine( "Неизвестная марка. Выберите одну из предложенных." );
                    IsSelectBrend = false;
                    break;
            }
        }
        return brand;
    }

    private IBody GetBody()
    {
        bool IsSelectBody = false;
        IBody body = null;
        while ( !IsSelectBody )
        {
            IsSelectBody = true;
            Console.Write( "Выберите кузов:\nкупе\nхэтчбек\nпикап\nседан\n>" );
            string bodyStr = Console.ReadLine();
            switch ( bodyStr )
            {
                case "купе":
                    body = new Coupe();
                    break;
                case "хэтчбек":
                    body = new Hatchback();
                    break;
                case "пикап":
                    body = new Pickup();
                    break;
                case "седан":
                    body = new Sedan();
                    break;
                default:
                    Console.WriteLine( "Неизвестный кузов. Выберите один из предложенных." );
                    IsSelectBody = false;
                    break;
            }
        }
        return body;
    }

    private IColor GetColor()
    {
        bool IsSelectColor = false;
        IColor color = null;
        while ( !IsSelectColor )
        {
            IsSelectColor = true;
            Console.Write( "Выберите цвет кузов:\nбелый\nчерный\nкрасный\nсиний\n>" );
            string colorStr = Console.ReadLine();
            switch ( colorStr )
            {
                case "белый":
                    color = new White();
                    break;
                case "черный":
                    color = new Black();
                    break;
                case "красный":
                    color = new Red();
                    break;
                case "синий":
                    color = new Blue();
                    break;
                default:
                    Console.WriteLine( "Выберите один из предложенных цветов." );
                    IsSelectColor = false;
                    break;
            }
        }
        return color;
    }

    private IEngine GetEngine()
    {
        bool IsSelectEngine = false;
        IEngine engine = null;
        while ( !IsSelectEngine )
        {
            IsSelectEngine = true;
            Console.Write( "Выберите двигатель:\nстандарт\nспорт\nтурбо\n>" );
            string engineStr = Console.ReadLine();
            switch ( engineStr )
            {
                case "стандарт":
                    engine = new Standart();
                    break;
                case "спорт":
                    engine = new Sport();
                    break;
                case "турбо":
                    engine = new Turbo();
                    break;
                default:
                    Console.WriteLine( "Неизвестный двигатель. Выберите один из предложенных." );
                    IsSelectEngine = false;
                    break;
            }
        }
        return engine;
    }

    private ITransmission GetTransmission()
    {
        bool IsSelectTransmission = false;
        ITransmission transmission = null;
        while ( !IsSelectTransmission )
        {
            IsSelectTransmission = true;
            Console.Write( "Выберите коробку передач:\nстандарт\nпремиум\n>" );
            string transmissionStr = Console.ReadLine();
            switch ( transmissionStr )
            {
                case "стандарт":
                    transmission = new Common();
                    break;
                case "премиум":
                    transmission = new Improved();
                    break;
                default:
                    Console.WriteLine( "Неизвестная коробка передач. Выберите одну из предложенных." );
                    IsSelectTransmission = false;
                    break;
            }
        }
        return transmission;
    }
}
