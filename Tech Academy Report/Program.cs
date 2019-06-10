using System;

namespace Tech_Academy_Report
{
    class Tech_Academy_Report
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            

            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string helpStatus = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(helpStatus);
           
            Console.WriteLine("Were there any positive experiences you would like to share? Please be specific.");
            string positiveExperience = Console.ReadLine();
            

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Feedback = Console.ReadLine();
            
            Console.WriteLine("How many hours did you study today?");
            string studyTime = Console.ReadLine();
            int hoursStudied = Convert.ToInt16(studyTime);
            
            
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}