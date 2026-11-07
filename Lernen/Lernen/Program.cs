// See https://aka.ms/new-console-template for more information
using Lernen;
/*
Motor m = new Motor( 3000,  20, 200000);
m.setDrehzahl(4000);
Console.WriteLine(m.getDrehzahl());

Auto tesla = new Auto(m, "Tesla", true, "Model S");
Console.WriteLine(tesla.e_auto);
Console.WriteLine(tesla.marke);
Console.WriteLine(tesla.Julian.getDrehzahl());
*/

Mensch mensch1 = new Mensch("Furkan");
Console.WriteLine(mensch1.name);
Console.WriteLine(mensch1.alter);
Console.WriteLine(mensch1.größe);
Console.WriteLine(mensch1.geburtstag);
Console.WriteLine(mensch1.gewicht);

Uhr Uhr1 = new Uhr("Rolex");
Uhr Uhr2 = new Uhr("PP");
Uhr Uhr3 = new Uhr("DemirUhr");

mensch1.armbanduhr = Uhr3;

Console.WriteLine(Uhr1.marke);
Console.WriteLine(Uhr2.marke);
Console.WriteLine(Uhr3.marke);
Console.WriteLine(mensch1.name + " trägt die Uhr " + mensch1.armbanduhr.marke);