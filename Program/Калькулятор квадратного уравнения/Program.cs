// See https://aka.ms/new-console-template for more information

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        { 
            
            
            Console.WriteLine(String.Join(" ,",Calc(0.5, 0.125, 0))); // 2 корня
            Console.WriteLine(String.Join(" ,", Calc(-4, 28, -49))); //Единственный корень
           Console.WriteLine(String.Join(" ,",Calc(3, -4, 94))); // Корней нет
           
           
           // Как вывести числа с плавающей запятой через точку, а не через запятую?)
        }

        private static double[] Calc(double a, double b, double c)
        {
            double[] result = {}; 
            var d = b*b - (4 * a * c); //Считаем дискрименант 
            switch (d) // В зависимости от значения d заносим в массив результата значение корня(ей) или -1 в случае его отсутсвия
            {
                case 0:
                    result  =   result.Append(-b / (2 * a)).ToArray();
                    break;
                case > 0:
                    result  = result.Append(-b - (Math.Sqrt(d) / (2 * a))).ToArray();
                    result =  result.Append(-b + (Math.Sqrt(d) / (2 * a))).ToArray();
                    break;
                default:
                    result  =   result.Append(-1).ToArray();
                    break;
            }
            return result; //Возвращем результат
        }
    }
}