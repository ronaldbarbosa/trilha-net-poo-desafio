using System.Diagnostics;
using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("654321", "Modelo 2", "222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");