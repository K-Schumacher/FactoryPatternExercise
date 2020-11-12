using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternExercise
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Start the vehicle");
            Thread.Sleep(1000);
            Console.WriteLine("Constructing build kit!");
            Thread.Sleep(1000);
        }
    }
}
