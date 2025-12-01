Console.WriteLine("Hello, world!");

char[] name = ['L', 'u', 'c', 'a', 's'];
string name1 = "Elieas";
IMonitor monitor = new MonitorDell();

monitor.Ligar();

interface IMonitor
{
    void Ligar();
}

sealed class MonitorDell : Monitor
{
    public string Color { get; set; } = "black";
}

class Monitor : IMonitor
{
    public string Color { get; set; } = "pink";

    public void Ligar()
    {
        Console.WriteLine($"Ligando...");
    }
}
