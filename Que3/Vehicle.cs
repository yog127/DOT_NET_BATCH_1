using System;
namespace Lift
{
    public class Vehicle : IClass
    {
        public virtual void LiftPlease(){
            Console.WriteLine("unkown Vehicle");
        }
    }
}