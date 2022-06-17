

//DO NOT FORGET TO CLOSE THE COMMAND PROMPT AFTER YOU COMPILE YOUR CODES!!!!!!!!//
//var result = Add2(20);
//ref keyword : iki aynı değişken tanımlandığında ve farklı değerler atandığında
//referans almamızı sağlar
//int number1 = 20;
//int number2 = 100;
//var result2 = Add3(  ref number1, number2);
//Console.WriteLine(result2);
//Console.WriteLine( number1);
//static int Add3( ref int number1, int number2)
//{
//    number1 = 30;
//    return number1 + number2;}

//static void Add()
//{

//    Console.WriteLine("Added!!!");
//}

//static int Add2(int x, int number1 = 992, int number2 = 86)
//{
//    var result = number1 + number2;
//    return result;
//}

Console.WriteLine(Multiply(2,4));




static int Multiply(int number1,int number2) {
    return number1 * number2;

}


static int Multiply(int number1, int number2,int number3)
{
    return number1 * number2 *number3 ;

}

Console.WriteLine(Multiply);



