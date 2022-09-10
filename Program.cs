using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia.");
Smartphone nokia = new Nokia("1234-5677", "Nokia", "1", 69);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Celular Iphone.");
Smartphone iphone = new Iphone("8765-4321", "Iphone", "2", -69);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");