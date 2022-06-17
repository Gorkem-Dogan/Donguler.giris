// See https://aka.ms/new-console-template for more information

int length = 8;
string kurs1 = "Yazılım geliştirici yetiştirme kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";


// array - dizi

string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java" }; 


for (int i = 0; i<kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}


Console.WriteLine("Sayfa Sonu  -  footer");