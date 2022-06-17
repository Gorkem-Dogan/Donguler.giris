namespace gorkemproje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();
            Console.WriteLine(math.Multiply(2, 4));

            Console.WriteLine(math.Multiply(2, 4, 6));
            Console.WriteLine(math.Add4 (12, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }
    class Maths
    {
        
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;

        }


        public int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;

        }
        

        public int Add4(params int[] numbers) 
        {
            return numbers.Sum();
        }
           
    
    
    
    
    
    
    
    
    }






}