using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello 1");
            String aa = "AAA";
            Debug.WriteLine("hello debug");
                
            try {
                Console.WriteLine("hello 2");
                //https://msdn.microsoft.com/en-us/library/d762ceey.aspx
                Debug.Assert(aa != "AAA" ,"TEST....");
                //Debug.Assert(aa == "AAA", "TEST....");
                //Debug.Assert(aa != "AAA");
                //Trace.Assert(aa != null, "Type parameter is null");
                //Debug.Fail("fail..");
            }
            catch (Exception ex) {
                ex.ToString();
            }
        }
    }
}
