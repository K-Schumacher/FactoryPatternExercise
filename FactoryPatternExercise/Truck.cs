using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Truck : IVehicle
    {
        public Truck()
        {
        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The truck is driving.");
        }

    }
}
