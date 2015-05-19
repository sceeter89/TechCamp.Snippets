using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCamp
{
   class UniqueItems
   {
      public void Do()
      {
         var list = new List<int>();
         int a = 0;

         if (list.Contains(a))
            list.Remove(a);

         list.Add(a);

         //Semantically equal
         list.Remove(a);
         list.Add(a);

         //Semantically equal
         var set = new HashSet<int>();

         set.Add(a);
      }
   }
}
