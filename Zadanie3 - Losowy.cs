using System;
const int iloscDanych = 100;
var data = DateTime.Now;
var rok = data.Year;
var miesiac = data.Month;
var dzien = data.Day;
var godzina = data.Hour;
var minuty = data.Minute;
var sekundy = data.Second;
string sciezka = "C:/test/users-"+rok+"_"+miesiac+"_"+dzien+"_"+godzina+"_"+minuty+"_"+sekundy+".csv";
var calosc = "ID,Imiona,Nazwiska,Rok urodzenia\n";
for (int i = 1; i < (iloscDanych+1); i++)
{
    List<string> imiona = new List<string> { "Ania", "Kasia", "Basia", "Zosia" };
    List<string> nazwiska = new List<string> { "Kowalska", "Nowak" };
    Random rng1 = new Random();
    int imionaLiczba = rng1.Next(0,4);
    int nazwiskaLiczba = rng1.Next(0,2);
    int rokLiczba = rng1.Next(1990,2001);
    calosc  += (i+","+imiona[imionaLiczba]+","+nazwiska[nazwiskaLiczba]+","+rokLiczba+"\n");
    
}
File.WriteAllText(sciezka, calosc);
Console.WriteLine(File.ReadAllText(sciezka));
