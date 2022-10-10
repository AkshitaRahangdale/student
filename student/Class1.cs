using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
        public class Stud
        { 
            private int roll,percent;
            private string name;
            
            public void Add()
            {
                roll = 10;
                name = "john";
                percent = 75;
            }

            public string print()
            {
                return $"Date:{roll}/{name}/{percent}";
            }

        } 
    }
    

