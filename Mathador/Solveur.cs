using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathador
{
    class Solveur
    {
        //Constructor
        public Solveur()
        {
        }
        
        /*
         * @function: solver
         * @parameter: 
         *  int[] n -> array of int with the 5 random values
         *  int r -> result to find
         * @return: int -> if return 1 mathador hit possible, else return 0
         */
        public static int solver(int[] n, int result)
		{
			bool loop_lock = true, 
				find = false;
			// n_lock = true;
			int a, r, i = 0, x, z =0;

			for (x = 0; x < 120; x++)
			{
				if (!loop_lock)
				{
					if (i == 0)
					{
						i = n[0];
						z = Array.IndexOf(n, i);

					}

					if (z < 4)
					{
						a = n[z];
						n[z] = n[z + 1];
						n[z + 1] = a;
						z++;
					}
					else
					{
						i = 0;
					}
				}

				r = (((n[0] * n[1]) + n[2]) - n[3]) / n[4];

				Console.WriteLine("try_number_{5} = {0}, {1}, {2}, {3}, {4} result = {6}", n[0], n[1], n[2], n[3], n[4], x, r);


				if (r == result)
					find = true;
				
				loop_lock = false;
			}
			if (find)
				return 1;
			return 0;
		}
    }
}
