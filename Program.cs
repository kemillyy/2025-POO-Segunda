﻿class Program
{
    static void Main()
    {

        Televisao tv = new Televisao(55);

        tv.Ligar();
        Console.WriteLine(tv);
        tv.AumentarVolume();
        tv.AumentarVolume();
        Console.WriteLine(tv);
        tv.AtivarOuDesativarMudo();
        Console.WriteLine(tv);
        tv.ProximoCanal();
        tv.ProximoCanal();
        Console.WriteLine(tv);
        tv.IrParaCanal(520);
        Console.WriteLine(tv);
        tv.ProximoCanal();
        Console.WriteLine(tv);
        tv.Desligar();
        Console.WriteLine(tv);
        tv.Ligar();
        Console.WriteLine(tv);
    }
}