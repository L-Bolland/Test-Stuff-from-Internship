using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    // looking at ideas how to structure the code
    internal class Example1
    {
        void MainMenu()
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
    internal class Example2
    {
        void Option1()
        {
            bool backToMainMenu = false;
            Option11();
            //Option12();
            //usw
            backToMainMenu = true; //question remains: how?
        }
        void Option2()
        {
            bool backToMainMenu = false;
            Option21();
            //Option22();
            //usw
            backToMainMenu = true;
        }
        void Option11()
        {
            //stuff
        }
        void Option21()
        {
            //stuff
        }
        void MainMenu()
        {
            int arg1 = 0;
            int arg2 = 0;
            Option1();
            Option2();
            //usw
        }
    }
}
