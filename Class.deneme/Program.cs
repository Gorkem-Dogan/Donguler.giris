// See https://aka.ms/new-console-template for more information

SarkiListesi sarki1 = new SarkiListesi();
sarki1.SarkiAdi = "Islak Islak";
sarki1.SanatciAdi = "Baris Akarsu";
sarki1.SarkiSuresi = "4:43";
sarki1.Album = "Islak Islak";

SarkiListesi sarki2 = new SarkiListesi();
sarki2.SarkiAdi = "Master of Puppets";
sarki2.SanatciAdi = "Metallica";
sarki2.SarkiSuresi = "8:35";
sarki2.Album = "Master of Puppets";

SarkiListesi[] sarkilar = new SarkiListesi[] {sarki1,sarki2 };

foreach (var sarki in sarkilar)
{
    Console.WriteLine(sarki.SarkiAdi + "  " + sarki.SanatciAdi + "  " + sarki.SarkiSuresi+ " Albüm adı: " + sarki.Album);
}
class SarkiListesi
{
    public string SarkiAdi { get; set; }
    public string SanatciAdi { get; set; }
    public string SarkiSuresi { get; set; }
    public string Album { get; set; }
}
