using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity1BL
{
    public class Instructor
    {
        private string instructorName;
        private float avgFeedback;
        private int experience;
        private string[] instructorSkill = new string[1000];


        public Instructor()
        {


        }

        public bool CheckSkill(string technology)
        {
            bool outcome = false;
            //if (instructorSkill.Contains(technology, StringComparison.OrdinalIgnoreCase))
            if (instructorSkill.Contains(technology,StringComparer.OrdinalIgnoreCase))
            {
                outcome = true;
            }
            return outcome;

        }




        public Instructor(string instructorName, float avgFeedback, int experience, string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;

        }

/*      
*/
        public bool ValidateEligibility(int experience, float avgFeedback)
        {
            /*if ((experience < 3   h) || (avgFeedback < 1.0 || avgFeedback > 5.0))
                {
                return false ;
                }
            else { return true; }
*/
            try
            {
                if ((experience < 3) || (avgFeedback < 1.0 || avgFeedback > 5.0))
                {
                    return false;
                }

            }
            catch (IndexOutOfRangeException e)
            {

                //throw("Can't proceed...Invalid input");
                Console.WriteLine(e.Message);
                // Set IndexOutOfRangeException to the new exception's InnerException.
                throw new ArgumentOutOfRangeException("Input parameter is out of range.", e);
            }

            finally
            {

            }
            return true;
        }


    }


    /*public bool CheckString(string instructorName)
    {
        bool outcome2 = false;
        try
        {
            if (instructorName.Equals(instructorName, StringComparison.OrdinalIgnoreCase)) 
            {
                outcome2 = true;
            }

        }
        catch (Exception)
        {

            throw;
        }

        finally
        {

        }
        return outcome2;
    }
*/


}
