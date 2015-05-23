using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TechCamp
{
   class Polyline : IEnumerable<Point>
   {
      public void Add(int x, int y) { }

      #region IEnumerable
      public IEnumerator<Point> GetEnumerator()
      {
         throw new NotImplementedException();
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         throw new NotImplementedException();
      }
      #endregion
   }

   internal class Point
   {
   }

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

      public void Do_()
      {
         var polyline = new Polyline();
         polyline.Add(0, 0);
         polyline.Add(0, 1);
         polyline.Add(1, 1);
         polyline.Add(2, 5);
         polyline.Add(3, 8);

         polyline = new Polyline
         {
            {0 ,0 },
            {0, 1 },
            {1, 1 },
            {2, 5 },
            {3, 8 }
         };
      }
   }
}
