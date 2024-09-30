using System;
namespace Lift
{
public class Bus : Vehicle
{
    public override void LiftPlease()
    {
        Console.WriteLine("lift from bus");
    }
}
}