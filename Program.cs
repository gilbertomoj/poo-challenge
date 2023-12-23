// See https://aka.ms/new-console-template for more information
using poo_challenge.Models;

Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Smartphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 128);

nokia.Ligar();
iphone.Ligar();

nokia.ReceberLigacao();
iphone.ReceberLigacao();

nokia.InstalarAplicativo("Snake");
nokia.InstalarAplicativo("Instagram");
nokia.InstalarAplicativo("Whatsapp");

iphone.InstalarAplicativo("Facebook");
iphone.InstalarAplicativo("Twitter");
iphone.InstalarAplicativo("Tinder");


nokia.ListarAplicativos();
iphone.ListarAplicativos();
