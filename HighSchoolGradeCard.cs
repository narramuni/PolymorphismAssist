using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class HighSchoolGradeCard : BasicGradeCard
    {
         int maths = 10;
         int english = 20;
         int secondLanguage = 30;
         int geography = 40;
         int history = 10;
         int physics = 20;
         int chemistry = 30;
         int biology = 40;

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

        public int Geography
        {
            get { return geography; }
            set { geography = value; }
        }

        public int History
        {
            get { return history; }
            set { history = value; }
        }

        public int Physics
        {
            get { return physics; }
            set { physics = value; }
        }

        public int Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }

        public int Biology
        {
            get { return biology; }
            set { biology = value; }
        }

        public virtual int getTotalMarks() 
        {
            this.totalMarks = maths + english + geography + history + physics + chemistry + biology;
            return totalMarks;
        }
    }



}
