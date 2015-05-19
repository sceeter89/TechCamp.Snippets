namespace TechCamp
{
   class ObjectInitializer
   {
      private class SomeClass
      {
         public int IntProperty { get; set; }
         public string StringProperty { get; set; }
         public float FloatProperty { get; set; }
      }

      public void Do()
      {
         var inastance = new SomeClass();
         instance.IntProperty = 1;
         instance.StringProperty = "abc";
         instance.FloatProperty = 1.4f;

         var instance = new SomeClass
         {
            IntProperty = 1,
            StringProperty = "abc",
            FloatProperty = 1.4f
         };
      }
   }
}
