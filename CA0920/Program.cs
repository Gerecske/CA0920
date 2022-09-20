using CA0920;

//beolvasas
List<Kuldetes> kuldetesek = new();

using StreamReader sr = new(@"..\..\..\res\kuldetesek.csv");
while (!sr.EndOfStream) kuldetesek.Add(new Kuldetes(sr.ReadLine()));

//f3
Console.WriteLine($"3.feladat:\n\tÖsszesen {kuldetesek.Count} alkalommal indítottak űrhajót.");