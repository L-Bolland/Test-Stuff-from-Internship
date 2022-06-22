using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    internal class Examples
    {
        // looking at ideas how to structure the code
        /*Example1:*/void MainMenu()
        {
            int option1;
            int option2;
            //usw
        }
        // if option 1 is selected, go to SubMenu1()
        void SubMenu1()
        {
            int option1;
            int option2;
            //usw
            int backToMainMenu; //how?
        }
    }
}
