using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Modelo Nokia1", "987654321", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("123456789", "Modelo Nokia1", "987654321", 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
