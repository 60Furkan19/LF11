// See https://aka.ms/new-console-template for more information
using Lernen;

Motor m = new Motor( 3000,  20, 200000);
m.setDrehzahl(4000);
Console.WriteLine(m.getDrehzahl());

Auto tesla = new Auto(m, "Tesla", true);
Console.WriteLine(tesla.e_auto);
Console.WriteLine(tesla.marke);
Console.WriteLine(tesla.Julian.getDrehzahl());