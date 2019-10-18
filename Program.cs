using System;
using Family.Models;

namespace Family
{
        
    
    class Program
    {
        static void Main(string[] args)
        {
            Husband Dave = new Husband();
            Wife Monica = new Wife();
            child Leo = new child();
            Dave.Cry();
            Monica.Cry();
            Leo.Cry();
            Dave.Fight();
            Monica.Fight();
            Leo.Fight();

        }
    }
    
}

