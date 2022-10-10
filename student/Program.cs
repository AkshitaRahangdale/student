using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stud s1 = new Stud();
            s1.Add();
            Console.WriteLine(s1.Print());

            Stud s2 = new Stud();
            s2.Add();
            Console.WriteLine(s2.Print());

         
        }
    }
}
