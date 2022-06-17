// See https://aka.ms/new-console-template for more 


DortIslem dortIslem = new DortIslem();
dortIslem.Topla(5, 6);
dortIslem.Topla(7, 8);
    
    
    
    
    
    class DortIslem
{
    // TOPLA(2,3)
    public void Topla(int sayi1, int sayi2)
    {
        int toplam = sayi1 + sayi2;
        Console.WriteLine("Sonuç : " + toplam);
    }
}




