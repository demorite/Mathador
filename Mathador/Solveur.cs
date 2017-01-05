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
         * @function: solve
         * @parameter: 
         *  int[] tab -> array of int with the 5 random values
         *  int result -> result to find
         * @return: int -> if return 1 mathador hit possible, else return 0
         */
       public static int solve(int[] tab, int result)
		{
			int i, j, r = 0, y, z;

			for (y = 0; y < 24; y++)
			{
				for (i = 0; i < tab.Length; i++)
				{
					for (z = 0; z < 24; z++)
					{
						switch (z)
						{
							case 0:
								r = tab[0] * tab[1] + tab[2] - tab[3] / tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} * {1} + {2} - {3} / {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 1:
								r = tab[0] + tab[1] * tab[2] - tab[3] / tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} * {2} - {3} / {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 2:
								r = tab[0] + tab[1] - tab[2] * tab[3] / tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} - {2} * {3} / {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 3:
								r = tab[0] + tab[1] - tab[2] / tab[3] * tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} - {2} / {3} * {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 4:
								r = tab[0] - tab[1] + tab[2] / tab[3] * tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} - {1} + {2} / {3} * {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 5:
								r = tab[0] + tab[1] - tab[2] / tab[3] * tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} - {2} / {3} * {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 6:
								r = tab[0] + tab[1] / tab[2] - tab[3] * tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} / {2} - {3} * {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 7:
								r = tab[0] + tab[1] / tab[2] * tab[3] - tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} / {2} * {3} - {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 8:
								r = tab[0] / tab[1] + tab[2] * tab[3] - tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} / {1} + {2} * {3} - {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 9:
								r = tab[0] + tab[1] / tab[2] * tab[3] - tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} / {2} * {3} - {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 10:
								r = tab[0] + tab[1] * tab[2] / tab[3] - tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} * {2} / {3} - {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 11:
								r = tab[0] + tab[1] * tab[2] - tab[3] / tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} * {2} - {3} / {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 12:
								r = tab[0] * tab[1] + tab[2] - tab[3] / tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} * {1} + {2} - {3} / {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 13:
								r = tab[0] * tab[1] - tab[2] + tab[3] / tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} * {1} - {2} + {3} / {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 14:
								r = tab[0] * tab[1] - tab[2] / tab[3] + tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} * {1} - {2} / {3} + {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 15:
								r = tab[0] - tab[1] * tab[2] / tab[3] + tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} - {1} * {2} / {3} + {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 16:
								r = tab[0] - tab[1] / tab[2] * tab[3] + tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} - {1} / {2} * {3} + {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 17:
								r = tab[0] - tab[1] / tab[2] + tab[3] * tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} - {1} / {2} + {3} * {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 18:
								r = tab[0] / tab[1] - tab[2] + tab[3] * tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} / {1} - {2} + {3} * {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 19:
								r = tab[0] / tab[1] + tab[2] - tab[3] * tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} / {1} + {2} - {3} * {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 20:
								r = tab[0] / tab[1] + tab[2] * tab[3] - tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} / {1} + {2} * {3} - {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 21:
								r = tab[0] + tab[1] / tab[2] * tab[3] - tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} / {2} * {3} - {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 22:
								r = tab[0] + tab[1] * tab[2] / tab[3] - tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} * {2} / {3} - {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							case 23:
								r = tab[0] + tab[1] * tab[2] - tab[3] / tab[4];
								if (r == result)
								{
									Console.WriteLine("{0} + {1} * {2} - {3} / {4} = {5}", tab[0], tab[1], tab[2], tab[3], tab[4], r);
									return 1;
								}
								break;

							default:
								r = 0;
								break;
						}
					}

					//else reorder the array
					if (i < 4)
					{
						j = tab[i];
						tab[i] = tab[i + 1];
						tab[i + 1] = j;
					}
				}
			}

			return 0;
		}
    }
}
