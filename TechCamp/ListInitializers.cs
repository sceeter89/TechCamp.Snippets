using System.Collections.Generic;
using System.Linq;

namespace TechCamp
{
   class ListInitializers
   {
      public void Do()
      {
         var list = new List<int>();
         list.Add(1);
         list.Add(2);
         list.Add(3);
         list.Add(4);
         list.Add(5);

         list = new List<int> { 1, 2, 3, 4, 5 };

         list = Enumerable.Range(1, 5).ToList();
      }
   }
}
