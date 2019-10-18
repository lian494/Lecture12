namespace  Family.Models
{
 class child : Human
 {
     public override void Cry()
     {
         System.Console.WriteLine("The child smiled");
     }
     
         public override void Fight()
         {
             System.Console.WriteLine("The child cried and went to sleep!");
         }
  }
 }   