using System.Text;

namespace Linq
{
    internal abstract class Program
    {
        static void Main(string[] args )
        {
            Int32[] numbers = new[] { 1, 1, 31, 3, 4, 3, 34, 5, 453, 55, 35, 3, 53, 5, 7, 67, 8, 3 };
            var sql = numbers.Where(x => x % 2 == 0).OrderBy(x => x);
            StringBuilder builder = new StringBuilder();
            foreach (var el in sql)
            {
                builder.Append($"{el}, ");
            }
            Console.WriteLine(builder);
        }
    }
}

