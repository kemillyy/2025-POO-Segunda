public class Cartao
{
    public virtual void Debitar(decimal valor )
    {
        Console.WriteLine($"o Valor de {valor:C} foi tirado da sua conta com sucesso!");
    }
}