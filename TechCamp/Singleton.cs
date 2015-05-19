namespace TechCamp
{
   public sealed class Singleton
   {
      private static Singleton _instance;

      public static Singleton Instance
      {
         get
         {
            if (_instance == null)
               _instance = new Singleton();

            return _instance;
         }
      }
   }

   public sealed class Singleton2
   {
      private static readonly Singleton2 _instance = new Singleton2();

      public static Singleton2 Instance
      {
         get
         {
            return _instance;
         }
      }
   }
}
