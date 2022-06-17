



//Görüldüğü üzere out keywordünü kullanırken static void içinde tanımlı olan değişkene bir değer atamak
//zorunluluğunda değiliz fakat methodu tanımladığımız yerde bu değişkene bir değer atamamız gerekir.
//Ref keywordünde ise static void içinde bir değer atamamız gerekirken method içersine atamamıza gerek yoktur.
//Bu keywordler veriye kendine atanan değerden ayrı olarak bir adresi kullanabilir hale getirir.


mat islem = new mat();
int number1=21 ;
int number2;
var result1 = islem.Add( ref number1, out number2);

Console.WriteLine(result1);


class mat 
{
    public int Add( ref int number1 , out int number2 ) {
        
        number2 = 23;
    return  number1 + number2;}
}
