using CA0920;

//beolvasas
List<Kuldetes> kuldetesek = new();

using StreamReader sr = new(@"..\..\..\res\kuldetesek.csv");
while (!sr.EndOfStream) kuldetesek.Add(new Kuldetes(sr.ReadLine()));

//f3
Console.WriteLine($"3.feladat:\n\tÖsszesen {kuldetesek.Count} alkalommal indítottak űrhajót.");

//f4
int utasokSzamanakOsszege = kuldetesek.Sum(x => x.UtasokSzama);
Console.WriteLine($"4.feladat\n\t{utasokSzamanakOsszege} utas indult az űrbe összesen");

//f5
int k7u = kuldetesek.Count(x => x.UtasokSzama <5);
Console.WriteLine($"5.feladat\n\tÖsszesen {k7u} alkalommal küldtek kevesebb, mint 5 embert az űrbe.");

//f6
var cuuusz = kuldetesek
    .Where( x=> x.SikloNeve == "Columbia")
    .OrderByDescending(x=>x.KilovesNapja)
    .First().UtasokSzama;

Console.WriteLine($"6.feladat\n\t" +
    $" {cuuusz} asztronauta volt a Columbia fedélzetének utolsó útján.");

//f7
Kuldetes litf = kuldetesek
    .OrderByDescending(x => x.KuldetesHossza)
    .First();

Console.WriteLine($"6.feladat\n\t" +
    $"A leghosszabb ideig a {litf.SikloNeve} volt távol a Földtől\n\t " +
    $"a {litf.Kod} küldetés során.\n\t" +
    $"Összesen {litf.KuldetesHossza} órát töltött távol a Földtől.");

//f8
Console.WriteLine("8. feladat\n\t" +
    "Évszám: ");
int evszam = int.Parse(Console.ReadLine());
int kszae = kuldetesek.Count(x => x.KilovesNapja.Year == evszam);
Console.WriteLine($"\tEbben az évben {kszae} küldetés volt.");

//f9
