//Console.WriteLine("Hello, OS");
using System.Collections;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "GT 2007";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Ferrari";
            car2.Model = "F40";
            car2.VIN = "B1";

            

            Book b1 = new Book();
            b1.Author = "J. K. Rowling";
            b1.Title = "Harry Potter";
            b1.ISBN = "0-000-00000-0";

            // ArrayLists are dynamatically sized
            // cool features sorting, remove items
            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(car1);
            //myArrayList.Add(car2);
            //myArrayList.Add(b1); // problem is cant distinguish between different data or object

            /*
            //will throgh an exception as book object cant be traversed by this loop
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car1.Make);
            }*/

            /*
            foreach (var item in myArrayList)
            {
                if (item is Car)
                {
                    Car car = (Car)item;
                    Console.WriteLine($"Car: {car.Make} {car.Model}");
                }
                else if (item is Book)
                {
                    Book book = (Book)item;
                    Console.WriteLine($"Book: {book.Title} by {book.Author} and ISBN:{book.ISBN}");
                }
            }*/

            //now for list AKA Generic List
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1); // now this will not accept by this list
            /*
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */


            // Dictionary<TKey, TValue>

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A1"].Model);

            string[] names = { "A", "B", "C", "D", "E", "F" };

            //Object Inistializer Synctax
            // No need for a constructor
            Car car3 = new Car { Make = "BMW", Model = "750li", VIN = "C1" };
            Car car4 = new Car { Make = "Nissam", Model = "740li", VIN = "D1" };

            //Collection Initializer
            List<Car> myCollectionList = new List<Car>()
            {
                new Car { Make = "Toyota", Model = "Supra", VIN = "E1"},
                new Car { Make = "Alfa", Model = "Altima", VIN = "F1"},
            };

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
