using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure.ADT
{
    public class Schools
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsSchoolOver100Years(int year)
        {
            if (year >= 100) return true;
            return false;
        }
    }
}
