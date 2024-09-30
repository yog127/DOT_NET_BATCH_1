using System;
namespace Lift
{
public class Car : Vehicle
{
    public override void LiftPlease()
    {
        Console.WriteLine("Lift from car");
    }
}
}