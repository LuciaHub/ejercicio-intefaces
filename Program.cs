using System;

namespace ejercicios_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Loro Loros = new Loro();
            Loros.charlar();
        }
    }
        interface Icharlatan {
            void charlar();
        }
    
       abstract class Animal {
       }
       class Loro : Animal, Icharlatan {
        public void charlar(){
          Console.WriteLine("charlando");
        }
       }
        class Delfin : Animal, Icharlatan {
             public void charlar(){
          Console.WriteLine("charlando");
        }
        }
        class Tortuga : Animal {
            public void charlar(){
          Console.WriteLine("charlando");
        }
        }
}   
