






Urun urun1 = new Urun();
urun1.Id = "212345562";
urun1.fiyat = 17;
urun1.ozellik = "Kipkirmizi domates";
urun1.isim = "domates";

Urun urun2 = new Urun();
urun2.Id = "023478952";
urun2.fiyat = 12;
urun2.ozellik = "Dev dişi sarımsak";
urun2.isim = "sarımsak";

Console.WriteLine("----------------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil armut",9);
sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);
Console.WriteLine("----------------------");


class SepetManager {

    public void Ekle2(string urunAdi,string ozellikler, double fiyat)
    {
        Console.WriteLine("Sepete Eklendi ! " + urunAdi);
    }
        public void Ekle(Urun urun) {

        Console.WriteLine("Sepete Eklendi ! " + urun.ozellik + urun.isim + urun.fiyat);
    }

}
public class Urun { 
    public string Id { get; set; }
    public double fiyat { get; set; }
    public string isim { get; set; }
    public string ozellik { get; set; }
}