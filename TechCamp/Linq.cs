using System;
using System.Collections.Generic;
using System.Linq;

namespace TechCamp
{
   class Linq
   {
      public void Do()
      {
         var numbers = Enumerable.Range(0, 100);

         var squares = numbers.Select(x => x * x);

         var even = squares.Where(x => x % 2 == 0);

         var product = even.Aggregate(1, (accumulator, i) => accumulator * i);
         var sum = even.Sum();
      }

      private int _myInteger = 10;

      private IEnumerable<int> GenerateNumbers()
      {
         var random = new Random();
         for (int i = 0; i < 100; i++)
            yield return random.Next();

         _myInteger = -10;
      }

      public void Act()
      {
         var numbers = GenerateNumbers();
         numbers.Select(x => x - 5);

         //_myInteger = ...?
      }
   }
}
