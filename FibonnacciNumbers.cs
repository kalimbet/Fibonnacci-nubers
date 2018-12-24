using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 1;
			int y = 1;
			
			
		    Console.Write(x + " " + y);
		    
		     for(int i = 0; i < 20; i++){
                int sum = x + y;
                Console.Write(" " + sum);
                x = y;
                y = sum;
                
            }
		        
		    
		}
	}
}
