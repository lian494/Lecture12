namespace Family.Models
{
    class Wife : Human
    {
        public override void Cry()
        {
            System.Console.WriteLine("It's already 9 o'clock,my son,go to sleep");
        }
        public override void Fight()
        {
            System.Console.WriteLine("No,dear,he have to go to school tomorrow!!!");
        }
    }
    
}