using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasks;

namespace Ch6_Program8
{
    class Ch6_Program8 : CT
    {
        static void Main(string[] args)
        {
            Header("05/14/2018", "Ch6_Program8",
            "input and display valid entries between 10 and 50.");
            int input = AskUserForInt("a number between 10 and 50");
            //asks user for input
            //checks whether number is between 10 and 50
            while (input > 10 && input < 50)
            {
                //if it is a valid entry, it will ask the user again
                //(Recursion)
                input = AskUserForInt("a number between 10 and 50");
            }
            Footer();
        }
    }
}
