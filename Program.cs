using System;

class Program
{
    static void Main(string[] args)
    {
        Bolt bolt = new Bolt { BoltNumber = 136 };
        Nut nut = new Nut { NutNumber = 5718 };

        Connection<Bolt, Nut> connection = new Connection<Bolt, Nut>
        {
            Bolt = bolt,
            Nut = nut
        };

        connection.Connect();
    }
}
// Класс Болт
class Bolt
{
    public int BoltNumber { get; set; }
}

// Класс Гайка
class Nut
{
    public int NutNumber { get; set; }
}

// Класс Соединение
class Connection<TBolt, TNut>
    where TBolt : Bolt
    where TNut : Nut
{
    public TBolt Bolt { get; set; }
    public TNut Nut { get; set; }

    public void Connect()
    {
        Console.WriteLine($"Болт {Bolt.BoltNumber} вкручен в гайку {Nut.NutNumber}");
    }
}