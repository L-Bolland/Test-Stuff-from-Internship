namespace Composite_Pattern
{
    public interface IPriced
    {
        public ushort getPrice();
    }

    public interface IManipulateContent<T>
    {
        public void add(T thing);
        public void remove(T thing);
    }

    // Maybe add some more interfaces with other stuff, if anything comes to mind

    public class Box : IPriced, IManipulateContent<IPriced>
    {
        private IList<IPriced> boxContents = new List<IPriced>();
        ushort addedContentPrices = 0;


        public void add(Box box)
        {
            boxContents.Add(box);
        }

        public void add(Product product)
        {
            boxContents.Add(product);
        }

        public void add(IPriced thing)
        {
            boxContents.Add(thing);
        }

        public void remove(IPriced thing)
        {
            boxContents.Remove(thing);
        }

        public ushort getPrice()
        {
            if (boxContents != null)
            {
                for (int i = 0; i < boxContents.Count; i++)
                {
                    addedContentPrices = boxContents[i].getPrice();
                }
            }
            return addedContentPrices;
        }
    }

    public class Product : IPriced
    {
        public ushort getPrice()
        {
            return 6000;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var box = new Box();
            char choice = '0';

            // Improve the following code.
            // Example: class options {1 = contents, 2 = manipulate, etc.} then new file "text" while (choice != valid option) and so on.
            // further improvement: give number for options and what they do as variables instead of writing it directly into printf.
            // special, out of scope: make a menu that can utilize the mouse so that people can click the options instead of having to type corresponding numbers.
            while ((choice < '1') || (choice > '4'))
            {
                Console.WriteLine("What do you want to do?\n" +
                "Press 1 to show contents\n" +
                "Press 2 to add or remove Items to/from the current box\n" +
                "Press 3 to get the combined Price of all items within the current box and the boxes inside of it (if there are any)\n" +
                "Press 4 to exit\n");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                if (choice < '1' || choice > '4')
                {
                    Console.WriteLine("Invalid selection. Please try again.\n");
                }
                switch (choice)
                {
                    case '1':
                        Console.WriteLine(box.getPrice());
                        break;
                    case '2':
                        bool manipulate = true;
                        while (manipulate == true)
                        {
                            choice = '0';
                            while (new CharacterResponseValidation().CheckIfNumber(choice) == true && ((choice < '1') || (choice > '2')))
                            {
                                Console.WriteLine("What do you wish to do?\n" +
                                    "Press 1 to add a Box\n" +
                                    "Press 2 to add a Product\n");
                                choice = Console.ReadKey().KeyChar;
                                Console.WriteLine("\n");
                            }
                            // if statement not working properly for some reason --> right now it takes too much time to figure out why, need to get on with the actual task
                            Console.WriteLine(new CharacterResponseValidation().CheckIfNumber(choice));
                            if (new CharacterResponseValidation().CheckIfNumber(choice) != true || (choice < '1') || (choice > '2'))
                            {
                                Console.WriteLine("Invalid selection. Please try again.\n");
                            }
                            switch (choice)
                            {
                                case '1':
                                    box.add(new Box());
                                    Console.WriteLine("Added a Box");
                                    break;
                                case '2':
                                    box.add(new Product());
                                    Console.WriteLine("Added a Product");
                                    break;
                            }
                            bool selectionValue = false;
                            char selectionChar = '0';
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
