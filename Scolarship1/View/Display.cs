using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarship1.View
{
    public class Display
    {
        public double Income { get; set; }
        public double AverageGrade { get; set; }
        public double Minwage { get; set; }
        public decimal SocialScholarship { get; set; }
        public decimal ExcellenceScholarship { get; set; }

        public void Input()
        {
            Console.Write("Enter income: ");
            Income = double.Parse(Console.ReadLine());

            Console.Write("Enter averagegrade: ");
            AverageGrade = double.Parse(Console.ReadLine());

            Console.Write("Enter minimumwage: ");
            Minwage = double.Parse(Console.ReadLine());
        }
       

        public void Output()
        {
            if (SocialScholarship == 0 && ExcellenceScholarship == 0)
            {
                Console.WriteLine("You cant get scolarship!");
            }
            else if (SocialScholarship > ExcellenceScholarship)
            {
                Console.WriteLine($"You get social scolarship {SocialScholarship} BGN");
            }
            else
            {
                Console.WriteLine($"You get exellent scolarship {ExcellenceScholarship} BGN");
            }
        }
    }
}
