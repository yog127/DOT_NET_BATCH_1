using System;
namespace Lift
{
public class Bike : Vehicle
{
    public override void LiftPlease()
    {
        Console.WriteLine("lift from Bike");
    }
}
}