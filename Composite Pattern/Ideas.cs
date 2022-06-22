using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Overview:
// Task: Create an example for the Composite Pattern.

//ICalculateable 
//+ getPrice() : number

//Kiste : ICalculateable
//++ calculateableThings: ICalculateable[]
//+ getPrice() : number
//   ruft getPrice auf alle elemente von calculateableThings auf und addiert diese(reduce) calculateableThings.reduce(acc, curr => acc+curr.getPrice(), 0)
//+ add(element: ICalculateable) : void

//Kiste kann Schuhe oder weitere Kisten enthaten

//Schuh : ICalculateable
//+ getPrice() : number

//         K<-- was ist der Preis deines Inhalts
//       /   \
//      K     S
//    /   \
//   S     S

// Solution Attempt: We have products, priced at 60 € (6000 Cents for easier calculations).
// We have boxes that can contain either products or other boxes, which, in turn, may again contain either products or boxes, and so on
// The user must be able to view the total price of all products contained within all boxes that are contained within the current box

// To achieve this goal:
// 1: It must be possible for the user to place any number of boxes and products within a box.
// 2: It must be possible for the user to navigate from one box into another, to place more products and boxes within a box below the currently selected box
// 3: There must be a distinction between boxes in case the user wishes to place more than one box within a box

namespace Composite_Pattern
{
    // looking at ideas how to structure the code
    internal class Idea1
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
        // This looks an awful lot like goto-commands which are generally frowned upon and should not be used.
    }
    internal class Idea2
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
        // By making everything a function, things can easily get overcomplicated and more complex than they need to be.
    }
}
