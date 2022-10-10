using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class Stud
    {
        private int roll, percent;
        private string name;

        public void Add()
        {
            roll = 10;
            name = "john";
            percent = 75;
        }

        public string Print()
        {
            return $"Date:{roll}/{name}/{percent}";
        }

    }
}
