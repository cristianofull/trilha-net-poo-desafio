using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia:");

Smartphone Nokia = new Nokia ("9876-54321", "G21", "00000000", 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine();

Console.WriteLine("SmartPhone Iphone:");

Smartphone Iphone = new Iphone ("93256-2154", "XR", "11111111", 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");