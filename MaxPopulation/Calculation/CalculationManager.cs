using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxPopulation.Data_Nodes;

namespace MaxPopulation.Calculation
{
    class CalculationManager
    {
        private CalculationManager() { }

        // Calculation done here can be accessed simply by Passing on the values.
        public static int CalculateMaxPopulatedYear(People []peopleList, int startYear, int endYear)
        {
            // 101 is number of years between 1900 - 2000.
            int[] populationEachYear = new int[endYear - startYear + 1];
            

            // Calculating by each year, and going through whole people list adding the index to birth year, and subtracting
            // from death year
            for(int i = 0; i < peopleList.Length; ++i)
            {
                populationEachYear[peopleList[i].GetBirthYear() - startYear] += 1;
                populationEachYear[peopleList[i].GetDeathYear() - startYear] -= 1;
            }


            // Getting Int with MaxPopulation, and MaxPopulation Index. and keeping count of Population each year,
            // and getting the max value. Max value Index added to startYear gives the first Year with Highest Population.
            // It can be more than one year that have the highest population, but we are only calculating the first year with higest Population.
      
            int maxPopulation = 0;
            int maxPopulationIndex = 0;
            int population = 0;
            for(int i = 0; i < populationEachYear.Length; ++i)
            {
                population += populationEachYear[i];

                if(population > maxPopulation)
                {
                    maxPopulation = population;
                    maxPopulationIndex = i;
                }
            }

            return startYear + maxPopulationIndex;
        }


    }
}
