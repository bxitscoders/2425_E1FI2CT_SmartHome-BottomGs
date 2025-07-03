// See https://aka.ms/new-console-template for more information
string _name = "";

while (_name != "Ende")
{
    Console.WriteLine("Bitte geben Sie ihren Namen ein.");

    _name = Console.ReadLine();

    if (string.IsNullOrEmpty(_name))
    {
        Console.WriteLine("Bitte Name eingeben");
    }
    else if (_name == "Ende")
    {
        return;
    }
    else if (string.IsNullOrWhiteSpace(_name))
    {
        Console.WriteLine("Bitte richtigen Name eingeben");
    }
    else
    {
        //Console.WriteLine("Hallo " +  _name);
        Console.WriteLine($"Hallo {_name}");

        string _code = "";
        for (int i = 2; i >= 0; i--)
        {

            Console.WriteLine("Bitte geben Sie ihren Code ein");
            _code = Console.ReadLine();

            if (_code == "1234")
            {
                Console.WriteLine("Willkommen Meister");
                break;
                // i = -1;
            }
            else
            {
                Console.WriteLine($"Der eigegebene Code war nicht korrekt, es " +
                    $"sind noch {i} Versuche offen.");
            }
        }

        List<string> _farben = new List<string>() {"Blau", "Grün", "Gelb", "Rot"};
        string _alleFarben = "";
        foreach (string farben in _farben)
        {
            _alleFarben += farben + ", ";
        }
        Console.WriteLine(_alleFarben);
    }

    
}