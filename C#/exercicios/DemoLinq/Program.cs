using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplo 01 - produz uma nova sequencia sem modificar o elemento individual
            //
            int[] scores = { 20, 81, 92, 12, 88 };

            /*IEnumerable<int> highScoresQuery =
            from score in scores
            where score > 80
            orderby score descending
            select score;

            foreach (var item in highScoresQuery)
            {
                Console.WriteLine(item);
            }*/

            //exemplo 02 - produz uma nova sequencia de elementos como no exemplo anterior, mas
            //dessa vez transforma em um novo tipo de objeto
            /*IEnumerable<string> highScoresQuery2 =
                    from score in scores
                    where score > 80
                    orderby score descending
                    select $"The score is {score}";

            foreach (var item in highScoresQuery2)
            {
                Console.WriteLine(item);
            }*/

            //exemplo 03 - recupera um único valor sobre a origem dos dados
            int highScoreCount =
                (from score in scores
                where score > 80
                select score).Count();
        }
    }
}
