using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/**
 * 
Input :arr[] = {3, 5, 1, 8, 9, 4}, 
           m = 4 
{3, 5, 1, 8}
{5, 1, 8, 9}, 
{1, 8, 9, 4}

winsum = 3+5+1+8	
sum = 3+5+1+8	
      -------
	 4

winsum = 3+5+1+8	-3 + 9
sum = 3+5+1+8		3+5+1+8	-3 + 9
      -------	+ -----------------------
	 4		4

winsum = 3+5+1+8	-3 + 9		-5 + 4
sum = 3+5+1+8		3+5+1+8	-3 + 9			3+5+1+8	-3 + 9		-5 + 4
      -------	+ -----------------------	+ ------------------------------------------
	 4		4					4

sum = 	  sum
      ----------
	6-4+1=3

 * 
 **/
