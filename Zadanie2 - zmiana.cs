using System;
    StreamReader sr = new StreamReader("C:/test/test_ern_wes 2.txt");
    var line = sr.ReadLine();
    var modified = "";
    while (line != null)
    {
        modified = line.Replace("praca", "job");
        line = sr.ReadLine();
    }
    DateTime dateandtime = DateTime.Today;
    var rok = dateandtime.Year;
    var miesiac = dateandtime.Month;
    var dobryMiesiac = miesiac.ToString();
    var dzien = dateandtime.Day;
    var dobryDzien = dzien.ToString();
    if (miesiac < 10)
    {
        dobryMiesiac = "0" + miesiac;
    }
    if (dzien < 10)
    {
        dobryDzien = "0" + dzien;
    }
    var sciezka = "C:/test/test_ern_wes 2_changed - " + dobryDzien + "." + dobryMiesiac + "." + rok+".txt";
    File.WriteAllText(sciezka, modified);
    Console.WriteLine(File.ReadAllText(sciezka));