using System.IO;

bool IsEnding = false;
string action;
string path = "dictionary.txt";
Console.WriteLine( "DICTIONARY" );
while ( !IsEnding )
{
    ShowMenu();
    action = Console.ReadLine();
    switch ( action )
    {
        case "1":
            TranslateWord( "eng" );
            break;
        case "2":
            TranslateWord( "rus" );
            break;
        case "3":
            IsEnding = true;
            break;
        default:
            Console.WriteLine( "Пожалуйста, введите 1, 2 или 3" );
            break;
    }
}

void ShowMenu()
{
    Console.WriteLine( "Выберите действие:" );
    Console.WriteLine( "[1] Перевести с английского на русский" );
    Console.WriteLine( "[2] Перевести с русский на английского" );
    Console.WriteLine( "[3] Выйти из DICTIONARY" );
    Console.Write( "Введите цифру: " );
}

void TranslateWord( string CurrentLanguage )
{
    Console.Write( "Введите ваше слово: " );
    string word = Console.ReadLine();
    string translate = SearchTranslateInDictionary( CurrentLanguage, word );
    if ( translate != null )
    {
        Console.WriteLine( $"Перевод вашего слова: {translate}" );
    }
    else
    {
        AddWordInDictionary( CurrentLanguage, word );
    }
}

string SearchTranslateInDictionary( string CurrentLanguage, string word )
{
    using ( StreamReader reader = new StreamReader( path ) )
    {
        string line;
        while ( ( line = reader.ReadLine() ) != null )
        {
            string[] words = line.Split( ':' );
            if ( CurrentLanguage == "eng" && words[ 0 ] == word )
            {
                return words[ 1 ];
            }
            else if ( CurrentLanguage == "rus" && words[ 1 ] == word )
            {
                return words[ 0 ];
            }

        }
    }
    return null;
}

void AddWordInDictionary( string CurrentLanguage, string word )
{
    Console.Write( "К сожалению, данное слово в словаре не найдено. Добавить его в словарь?('да' или 'нет'): " );
    string answer = Console.ReadLine();
    while ( answer != "да" && answer != "нет" )
    {
        Console.WriteLine( "Пожалуйста, введите 'да' или 'нет': " );
        answer = Console.ReadLine();
    }
    if ( answer == "да" )
    {
        Console.Write( "Введите перевод вашего слова: " );
        string translate = Console.ReadLine();
        using ( StreamWriter writer = new StreamWriter( path, true ) )
        {
            if ( CurrentLanguage == "eng" )
            {
                writer.WriteLine( $"{word}:{translate}" );
            }
            else
            {
                writer.WriteLine( $"{translate}:{word}" );
            }
        }
    }
}