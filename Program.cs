using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {

            ElementarySchoolGradeCard elementary = new ElementarySchoolGradeCard();
            elementary.Maths = 90;
            elementary.English = 78;
            elementary.SecondLanguage = 80;
            elementary.SocialScience = 96;
            Console.WriteLine("total marks =" +
                              elementary.getTotalMarks());
            Console.ReadLine();

            MiddleSchoolGradeCard middle = new MiddleSchoolGradeCard();
            middle.Maths = 90;
            middle.English = 78;
            middle.SecondLanguage = 80;
            middle.Geography = 87;
            middle.History = 76;
            Console.WriteLine("total marks =" + middle.getTotalMarks());
            Console.ReadLine(); 

            HighSchoolGradeCard high = new HighSchoolGradeCard();
            high.Maths = 90;
            high.English = 78;
            high.SecondLanguage = 80;
            high.Geography = 87;
            high.History = 76;
            high.Physics = 90;
            high.Chemistry = 76;
            high.Biology = 96;
            Console.WriteLine("total marks =" + high.getTotalMarks());
            Console.ReadLine();
        }

        


    }


}
