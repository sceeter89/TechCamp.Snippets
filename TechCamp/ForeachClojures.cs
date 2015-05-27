using System;
using System.Collections.Generic;
using System.Linq;

namespace TechCamp
{
   class ForeachClojures
   {
      public static void Main(string[] args)
      {
         var actions = new List<Action>();

         foreach (var value in Enumerable.Range(0, 5))
            actions.Add(() => Console.WriteLine(value));

         foreach (var action in actions)
            action();
      }
   }
}
