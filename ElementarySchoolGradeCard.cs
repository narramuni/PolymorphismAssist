using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class ElementarySchoolGradeCard :BasicGradeCard
    {
        public int maths = 70;
        public int english = 80;
        public int secondLanguage = 86;
        public int socialScience = 92;

        public int Maths
        {
            get { return maths; }
            set { maths = value; }
        }

        public int English
        {
            get { return english; }
            set { english = value; }
        }

        public int SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }

        public int SocialScience
        {
            get { return socialScience; }
            set { socialScience = value; }
        }

        public virtual int getTotalMarks()
        {
            this.totalMarks = maths + english + socialScience + secondLanguage;
            return totalMarks;
        }



        }
    }
