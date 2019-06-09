using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MaxPopulation.Calculation;
using MaxPopulation.Data_Nodes;

namespace MaxPopulation.TestCases
{
    class TestValues
    {
        private TestValues() { }

        public static void RunTests()
        {
            // Test Case 1 - Random Data
            People[] Case01 = new People[10];
            Case01[0] = new People(1900, 1930);
            Case01[1] = new People(1920, 1970);
            Case01[2] = new People(1947, 1998);
            Case01[3] = new People(1923, 1989);
            Case01[4] = new People(1953, 2000);
            Case01[5] = new People(1945, 1978);
            Case01[6] = new People(1902, 1930);
            Case01[7] = new People(1976, 1996);
            Case01[8] = new People(1945, 2000);
            Case01[9] = new People(1999, 2000);

            int answer01 = CalculationManager.CalculateMaxPopulatedYear(Case01, 1900, 2000);
            Debug.WriteLine("\n Case 01 Year With Max Population: {0} \n", answer01);

            // Test Case 2 - Data with Same Birth Year
            People[] Case02 = new People[10];
            Case02[0] = new People(1920, 1930);
            Case02[1] = new People(1920, 1970);
            Case02[2] = new People(1920, 1998);
            Case02[3] = new People(1920, 1989);
            Case02[4] = new People(1920, 2000);
            Case02[5] = new People(1920, 1978);
            Case02[6] = new People(1920, 1930);
            Case02[7] = new People(1920, 1996);
            Case02[8] = new People(1920, 2000);
            Case02[9] = new People(1920, 2000);

            answer01 = CalculationManager.CalculateMaxPopulatedYear(Case02, 1900, 2000);
            Debug.WriteLine("\n Case 02 Year With Max Population: {0} \n", answer01);

            // Test Case 3 - Data with Same Death Year
            People[] Case03 = new People[10];
            Case03[0] = new People(1910, 2000);
            Case03[1] = new People(1913, 2000);
            Case03[2] = new People(1900, 2000);
            Case03[3] = new People(1955, 2000);
            Case03[4] = new People(1934, 2000);
            Case03[5] = new People(1978, 2000);
            Case03[6] = new People(1992, 2000);
            Case03[7] = new People(1934, 2000);
            Case03[8] = new People(1987, 2000);
            Case03[9] = new People(1934, 2000);

            answer01 = CalculationManager.CalculateMaxPopulatedYear(Case03, 1900, 2000);
            Debug.WriteLine("\n Case 03 Year With Max Population: {0} \n", answer01);
        }
    }
}
