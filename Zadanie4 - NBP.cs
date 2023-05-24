using System;
const double usd = 0.24;
Console.WriteLine("Podaj kwotę PLN");
Console.Write(">"); var kwota = Console.ReadLine();
bool isNumber = int.TryParse(kwota, out int result);
var koniec = "";
int kwotaInt = 0;
if (isNumber == true)
{
    kwotaInt = Int32.Parse(kwota);
}
var kwotausd = kwotaInt * usd;
Console.WriteLine("Kwota USD to \n" + kwotausd);