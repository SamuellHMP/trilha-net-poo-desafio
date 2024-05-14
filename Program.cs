using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");

Console.WriteLine("");

Console.WriteLine("iPhone:");
Smartphone iphone = new Nokia("654321", "Modelo 2", "222222222", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");
