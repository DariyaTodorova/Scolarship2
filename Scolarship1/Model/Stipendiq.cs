using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarship1.Model
{
    public class Stipendiq
    {
        private double income;
        
        public double Income
        {
            get { return this.income; }
            
            set
            {
             this.Income = value;
            }
        }
        private double averageGrade;

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set { averageGrade = value; }
        }

        private double minWage;

        public double Minwage
        {
            get { return this.minWage; }
            set { this.minWage = value; }
        }
       

       
        public decimal CalculateExcellenceScholarship()
        {
            if (AverageGrade >= 5.5)
            {
                return (decimal)(AverageGrade * 25);
            }
            else
            {
                return 0;
            }
        }

        public decimal CalculateSocialScholarship()
        {
            if (Income < Minwage && AverageGrade > 4.5)
            {
                return (decimal)(Minwage * 0.35);
            }
            else
            {
                return 0;
            }
        }
    }
}
