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
    // Problem1: how should the code be structured?
    internal class Idea11
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
    internal class Idea12
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

// Examples for a possible solution in TypeScript. Read, Understand, Replicate in C#.

// Example 1:
//
//import readline from "readline";
//const rl = readline.createInterface({
//    input: process.stdin, //or fileStream 
//    output: process.stdout
//});
//interface IView
//{
//    type: string;
//    render() : Promise<void>;
//    setRouter(router: Router) : void;
//}
//class HomeView implements IView
//{
//    type = "HomeView";
//    router: Router
//    setRouter(router: Router) {
//        this.router = router;
//    }
//    async render() {
//        console.log("[1] CoffeeView");
//        console.log("[2] FruitView");
//        for await(const line of rl) {
//            switch (line)
//            {
//                case "1":
//                    // business logic
//                    this.router.route("CoffeeView")
//                    break;
//                case "2":
//                    // business logic 
//                    this.router.route("FruitView")
//                    break;
//                default:
//                    break;
//            }
//        }
//    }
//}
//class CoffeeView implements IView
//{
//    type = "CoffeeView";
//    router: Router
//    selectedCoffee: string;
//    setRouter(router: Router) {
//        this.router = router;
//    }
//    async render() {
//        console.log("[1] Coffee");
//        console.log("[2] Latte Macchiato");
//        console.log("[0] Zurück");
//        for await(const line of rl) {
//            switch (line)
//            {
//                case "1":
//                    this.selectedCoffee = "Coffee";
//                    break;
//                case "2":
//                    this.selectedCoffee = "Latte Macchiato";
//                    break;
//                case "0":
//                    this.router.route("HomeView")
//                    break;
//                default:
//                    break;
//            }
//        }
//    }
//}
//class FruitView implements IView
//{
//    type = "FruitView";
//    router: Router
//    setRouter(router: Router) {
//        this.router = router;
//    }
//    async render() {
//    }
//}
//class ErrorView implements IView
//{
//    type = "ErrorView";
//    router: Router
//    setRouter(router: Router) {
//        this.router = router;
//    }
//    async render() {
//    }
//}
//class Router
//{
//    views: IView[];
//    curr: IView;
//    constructor(view: IView, views: IView[])
//    {
//        this.curr = view;
//        this.views = views;
//    }
//    route(viewName: string)
//    {
//        const nextView = this.views.find(view => view.type === viewName);
//        this.curr = nextView ? nextView : new ErrorView();
//    }
//}
//const home = new HomeView();
//const coffee = new CoffeeView();
//const fruit = new FruitView();
//const router = new Router(home, [home, coffee, fruit]);
//home.setRouter(router);
//coffee.setRouter(router);
//fruit.setRouter(router);
//while (true)
//{
//    await router.curr.render();
//    // nothing to do -> repeat
//}

// Example 2:
//
//                                                                                        ----> Backend1
//  User -> Input -> Frontend Anwendung --------------> Internet ----------> ReverseProxy ----> Backend2
//                                                                                        ----> Backend3
//interface IBackend
//{
//    execute() : void;
//}
//const useRoundRobin = (proxy: Proxy) =>  {
//    proxy.last = proxy.last + 1  % proxy.backends.length // setze rest der division
//}
//class Proxy implements IBackend
//{
//    backends: IBackend [];
//    strategy: (proxy: Proxy) => void;
//    last: number = 0;
//    constructor(backends : IBackend [], strategy: (proxy: Proxy) => void) {
//        this.backends = backends;
//        this.strategy = strategy;
//    }
//    public execute()
//{
//    this.backends[this.last].execute()
//        this.strategy(this);
//}
//}
//class Backend implements IBackend
//{
//    id: string;
//    constructor(id: string) {
//        this.id = id;
//    }
//    public execute(): void
//{
//    console.log(`I bimz Backend ${ this.id}`)
//    }
//}
//const backend1 = new Backend("1");
//const backend2 = new Backend("2");
//const backend3 = new Backend("3");
//const ReverseProxy = new Proxy([backend1, backend2, backend3], useRoundRobin)
//ReverseProxy.execute();
//ReverseProxy.execute();
//ReverseProxy.execute();
//ReverseProxy.execute();