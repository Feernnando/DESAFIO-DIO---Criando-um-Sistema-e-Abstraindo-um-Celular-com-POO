using Desafio_POO.Models;

Console.WriteLine("---------- Nokia ------------");
Nokia novoNokia = new Nokia("(11)9 8547-3216", "Nokia C30", "3567891203456789",64);
novoNokia.Ligar();
novoNokia.ReceberLigacao();
novoNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("---------- Iphone ------------");
Iphone novoIphone = new Iphone("(11)9 9876-5432", "Iphone 13", "3567891234567890",128);
novoIphone.Ligar();
novoIphone.ReceberLigacao();
novoIphone.InstalarAplicativo("Instagram");