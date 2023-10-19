using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class MiddleSchoolGradeCard : BasicGradeCard
    {
        public int maths = 60;
        public int english = 70;
        public int secondLanguage = 80;
        public int geography = 90;
        public int history = 96;

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

        public virtual int getTotalMarks()
        {
            this.totalMarks = maths + english + geography + history;
            return totalMarks;
        }
    }


}
