using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new ("12 934567891", "Nokia 3310", "Preto", 123456789);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new ("12 987654321", "Iphone 15", "Branco", 987654321);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");