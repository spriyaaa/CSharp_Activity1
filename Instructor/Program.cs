using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity1BL;

namespace Activity1UI
{
    class Program
    {
        static void Main(string[] args)
        {
  
            //float AvgFeedback = Convert.ToSingle(Console.ReadLine());
           /* string instructorName = Console.ReadLine();
            float AvgFeedback = (float)Convert.ToDouble(Console.ReadLine());
            int experience = Convert.ToInt32(Console.ReadLine());

            string[] instructorSkill = new string[1000];
     
            
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter skills of instructor:");

            for (int i = 0; i < n; i++)
            {

                instructorSkill[i] = Console.ReadLine();
            }*/

            string[] Skill = { "Java", "c#", "Python" };
            
            Instructor ins = new Instructor( "simran", 4, 4, Skill);
            

            //Instructor ins = new Instructor(5.6, 4, "sudha", "java");


            ins.CheckSkill("Java");
            ins.CheckSkill("python");
            ins.ValidateEligibility(5, 5);

        }


        
    }

    
}
