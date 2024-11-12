using System;

namespace Matlab
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = @"c:\temp\people\people.json";

            JsonMatLab jsonMatLab = new JsonMatLab();

            try
            {
                double avgAge = jsonMatLab.GetAverageAge(jsonFilePath);

                Console.WriteLine("Average Age: " + avgAge);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
