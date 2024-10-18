using Scolarship1.Model;
using Scolarship1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarship1.Controller
{
    public class ScolController
    {
        Display myDisp = new Display();
        Stipendiq myScol = new Stipendiq();

        public ScolController()
        {
            
            myDisp.Input();

            myScol.Income = myDisp.Income;
            myScol.AverageGrade = myDisp.AverageGrade;
            myScol.Minwage = myDisp.Minwage;

            myDisp.SocialScholarship = myScol.CalculateSocialScholarship();
            myDisp.ExcellenceScholarship = myScol.CalculateExcellenceScholarship();

            
            myDisp.Output();
        }
    }       
}
