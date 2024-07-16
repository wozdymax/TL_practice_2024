string product = RequestProduct();
string quantity = RequestQuantity();
string name = RequestName();
string address = RequestAddress();
Console.WriteLine();

string confirmation = OrderConfirmition( product, quantity, name, address );

if ( confirmation == "н" )
{
    OrderChanging( product, quantity, name, address, confirmation );
}

Console.WriteLine();
Console.WriteLine( $"Спасибо за совершенный заказ! Ожидайте доставку к {DateTime.Now.AddDays( 3 ):dd MMMM}" );

static string RequestProduct()
{
    Console.Write( "Введите название товара, который желаете приобрести: " );
    string product = Console.ReadLine();
    while ( String.IsNullOrEmpty( product ) )
    {
        Console.Write( "Пожалуйста, введите название товара: " );
        product = Console.ReadLine();
    }

    return product;
}

static string RequestQuantity()
{
    Console.Write( "Введите количество товара: " );
    string quantityStr = Console.ReadLine();
    while ( !int.TryParse( quantityStr, out int quantity ) )
    {
        Console.Write( "Пожалуйста, введите натуральное число: " );
        quantityStr = Console.ReadLine();
    }

    return quantityStr;
}

static string RequestName()
{
    Console.Write( "Введите ваше имя: " );
    string name = Console.ReadLine();
    while ( String.IsNullOrEmpty( name ) )
    {
        Console.Write( "Пожалуйста, введите ваше имя: " );
        name = Console.ReadLine();
    }

    return name;
}

static string RequestAddress()
{
    Console.Write( "Введите адрес доставки: " );
    string address = Console.ReadLine();
    while ( String.IsNullOrEmpty( address ) )
    {
        Console.Write( "Пожалуйста, введите адрес доставки: " );
        address = Console.ReadLine();
    }

    return address;
}

static string OrderConfirmition( string product, string quantity, string name, string address )
{
    Console.WriteLine( $"{name}, вы хотите заказать у нас {product} в количестве {quantity} штук, по адресу: {address}." );
    Console.Write( "Все верно? Введите одну букву ([д]да или [н]нет): " );
    string response = Console.ReadLine();

    while ( response != "д" && response != "н" )
    {
        Console.Write( "Пожалуйста, введите 'д' или 'н': " );
        response = Console.ReadLine();
    }

    return response;
}

static void OrderChanging( string product, string quantity, string name, string address, string confirmation )
{
    string change;
    while ( confirmation == "н" )
    {
        Console.WriteLine( "Что вы хотите изменить? Введите одну цифру: " );
        Console.WriteLine( "[1] товар" );
        Console.WriteLine( "[2] количество" );
        Console.WriteLine( "[3] ваше имя" );
        Console.WriteLine( "[4] адрес доставки" );
        change = Console.ReadLine();
        switch ( change )
        {
            case "1":
                product = RequestProduct();
                break;
            case "2":
                quantity = RequestQuantity();
                break;
            case "3":
                name = RequestName();
                break;
            case "4":
                address = RequestAddress();
                break;
            default:
                Console.WriteLine( "Если вы действительно хотите изменить какие-то данные в заказе, в следующий раз введите цифру от 1 до 4" );
                break;
        }
        confirmation = OrderConfirmition( product, quantity, name, address );
    }
}




