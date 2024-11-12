using System;
using System.IO;
using MLApp;

namespace Matlab
{
    internal class JsonMatLab
    {
        public double GetAverageAge(string jsonFilePath)
        {
            MLApp.MLApp matlab = new MLApp.MLApp();

            string jsonContent = File.ReadAllText(jsonFilePath);

            object result = null;

            matlab.Execute(@"addpath('C:\temp\matlabFunction');");
            matlab.Feval("myfunc", 1, out result, jsonContent);

            if (result is object[] resultArray && resultArray.Length > 0)
            {
                double avgAge = (double)resultArray[0];
                return avgAge;
            }
            else
            {
                throw new Exception("Unexpected result format.");
            }
        }
    }
}
