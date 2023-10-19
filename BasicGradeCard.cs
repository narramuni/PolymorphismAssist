﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BasicGradeCard
    {
        public int totalMarks;

        public BasicGradeCard()
        {
            totalMarks = 100;
        }

        public virtual int getTotalMarks()
        {
            return totalMarks;
        }

    }
}
