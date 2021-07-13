using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity1BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1BL.Tests
{
    [TestClass()]
    public class InstructorTests
    {
        [TestMethod()]
        public void InstructorTest()
        {

        }

        [TestMethod()]
        public void CheckSkillTest()
        {
            
            string[] Skill = { "Java", "c#", "Python" };

            Instructor ins = new Instructor("simran", 4, 4, Skill);
            bool actual = ins.CheckSkill("python");
            bool expected = true;
            Assert.AreEqual(actual, expected);

            
            bool actual1 = ins.CheckSkill("JAVA");
            bool expected1 = true;
            Assert.AreEqual(actual1, expected1);

            
            bool actual2= ins.CheckSkill("C");
            bool expected2 = false;
            Assert.AreEqual(actual2, expected2);

        }

        [TestMethod()]
        public void InstructorTest1()
        {

        }

       

        [TestMethod()]
        public void ValidateEligibilityTest()
        {
            //Instructor ins = new Instructor("sudha",5.6, 4, "java");
            string[] Skill = { "Java", "c#", "Python" };

            Instructor ins1 = new Instructor("sudha", 4, 4, Skill);
            bool actual = ins1.ValidateEligibility(4, 5);
            bool expected = true;
            Assert.AreEqual(actual, expected);


            Instructor ins = new Instructor("simran", 4, 4, Skill);
            bool actual1 = ins.ValidateEligibility(5, 4);
            bool expected1 = true;
            Assert.AreEqual(expected1, actual);

           
            bool actual2 = ins.ValidateEligibility(-1,6);
            bool expected2 = false;
            Assert.AreEqual(expected2, actual2);


        }


        /*       [TestMethod()]
               public void CheckStringTest()
               {
                   Instructor ins = new Instructor();
                   bool actual3 = ins.CheckString("sudhA");
                   bool expected3 = true;
                   Assert.AreEqual(expected3, actual3);

                   bool actual4 = ins.CheckString("sudha");
                   bool expected4 = true;
                   Assert.AreEqual(expected4, actual4);


               }*/
    }
}