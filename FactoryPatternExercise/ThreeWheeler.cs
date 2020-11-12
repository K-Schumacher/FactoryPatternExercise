using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("Let's get goin!");
        }
    }
}
