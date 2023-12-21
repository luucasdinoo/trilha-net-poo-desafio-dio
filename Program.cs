using DesafioPOO.Models;
// Testes

Console.WriteLine("Iphone 1");
Smartphone iphone1 = new Iphone("123456789","Iphone 14","111111111-1",256);
iphone1.Ligar();
iphone1.InstalarAplicativo("Twitch");

Console.WriteLine("------------------------------------------------------");

Console.WriteLine("Iphone 2");
Smartphone iphone2 = new Iphone("987654321", "Iphone 12", "22222222222-1", 128);
iphone2.ReceberLigacao();
iphone2.InstalarAplicativo("Facebook");

Console.WriteLine("------------------------------------------------------");

Console.WriteLine("Nokia 1");
Smartphone nokia = new Nokia("1357986431","Nokia Tijolão","333333333333-1",32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("------------------------------------------------------");

Console.WriteLine("Nokia 2");
Nokia nokia2 = new Nokia("9080706050", "Nokia Novo", "4444444444444-1", 128);
nokia2.Ligar();
nokia2.InstalarAplicativo("Clash Royale");
