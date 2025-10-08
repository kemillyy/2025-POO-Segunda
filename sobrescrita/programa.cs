// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Vendinha Do Seu Zé");

CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

Cartao cartaobase = new Cartao();
cartaobase.Debitar(100);

Console.WriteLine(" -- Cartão de Débito -- ");

Cartao CartaoDebito = new CartaoDebito();
CartaoDebito.Debitar(100);