using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }
        
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The motorcycle is revving up!");
        }

    }
}
