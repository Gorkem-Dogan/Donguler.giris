// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


string adi = "Engin";
int yas = 36;

Kurs kurs1= new Kurs();
kurs1.KursAdi = "C#";
kurs1.KursunEgitmeni = "Engin Demirog";
kurs1.IzlenmeOrani = 74;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.KursunEgitmeni = "Kerem Varış";
kurs2.IzlenmeOrani = 86;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Phyton";
kurs3.KursunEgitmeni = "Berkay Bilgin";
kurs3.IzlenmeOrani = 68;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "C++";
kurs4.KursunEgitmeni = "Murat Kurtboğan";
kurs4.IzlenmeOrani = 100;




Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4  };

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
};

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);
class Kurs
{
    public string KursAdi { get; set; }
    public string KursunEgitmeni { get; set; }
    public int    IzlenmeOrani { get; set; }
}