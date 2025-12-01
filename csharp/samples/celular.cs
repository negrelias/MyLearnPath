
var iphoneDeElias = new iPhone();
iphoneDeElias.LigaTela();

class iPhone : Celular
{
    public override string Marca => "Apple";

    public override void LigaTela()
    {
        base.LigaTela();
        Console.WriteLine($"meu iphone");
    }
}

abstract class Celular
{
    public virtual string Marca { get; }
    public virtual void LigaTela()
    {
        Console.WriteLine($"Ligando a tela do celular {Marca}");
    }
}