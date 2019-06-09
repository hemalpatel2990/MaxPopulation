using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPopulation.Data_Nodes
{
    class People
    {
        public People(int birth, int death)
        {       
            birthYear = birth;
            deathYear = death;
        }

        public int GetBirthYear()
        {
            return birthYear;
        }

        public int GetDeathYear()
        {
            return deathYear;
        }

        private readonly int birthYear;
        private readonly int deathYear;
    }
}
