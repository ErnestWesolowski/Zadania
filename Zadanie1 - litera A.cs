using System;
var ilosca = 0;
    StreamReader sr = new StreamReader("C:/test/test_ern_wes.txt");
    var line = sr.ReadLine();
    while (line != null)
    {
        Console.WriteLine(line);
    for (var i = 0; i < line.Length; i++)
    {
        var chunk = line.Substring(i, 1);
        if (chunk == "a")
        {
            ilosca++;
        }
    }
    line = sr.ReadLine();
    }

Console.WriteLine("Litera 'a' występuje " + ilosca+ " razy");