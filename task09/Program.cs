using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace task09
{

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem1
            //foreach(Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{day}, {(int)day}");
            //}
            ////mainly it is good when the values must match external systems
            #endregion

            #region Problem2
            //foreach (Grades g in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{g}, {(int)g}");
            //}
            ////If a value assigned to an enum member exceeds the underlying type’s range,
            ////a compile-time error occurs. However, if an out-of-range value is forced via casting at runtime,
            ////it results in overflow behavior according to the underlying type.
            #endregion

            #region Problem3
            //Person p1 = new Person(23, "Youssef", "Computer Engineering");
            //Person p2 = new Person(25, "Rayan Gigs", "CS");
            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());
            ////The virtual keyword allows a property to be overridden in a derived class,
            ////enabling runtime polymorphism and dynamic behavior based on the object's actual type.
            #endregion

            #region Problem4
            //Child ch1 = new Child(250.000);
            //ch1.DisplaySalary();
            ////A sealed property or method cannot be overridden because the sealed keyword prevents further inheritance modifications.
            ////It ensures that the implementation in the current class is final and cannot be changed by derived classes.
            #endregion

            #region Problem5
            //Rectangle r1 = new Rectangle(3, 5);
            //double Prim = Utility.CalculateRectanglePreimeter(r1.Length,r1.Width);
            //Console.WriteLine($"Rectangle Primeter is {Prim}");
            ////Static members belong to the class and can be accessed without creating an object,
            ////while object members belong to individual instances and require object creation to access them.
            #endregion

            #region Problem6
            //ComplexNumber c1 = new ComplexNumber(2, 3);
            //ComplexNumber c2 = new ComplexNumber(4, 5);
            //ComplexNumber c3 = c1 * c2;
            //Console.WriteLine(c3.ToString());
            ////we can overload many operators in C#, but not all. Operators like +, -, *, / can be overloaded,
            ////while operators such as ., ?:, sizeof, typeof cannot,
            ////because they are intrinsic to the language syntax and must maintain consistent behavior.
            #endregion

            #region Problem7
            //foreach(Gender g in Enum.GetValues(typeof(Gender)))
            //{
            //    Console.WriteLine($"Gender :{g.ToString()}, No. : {(int)g} ");
            //}
            //Console.WriteLine($"Byte Gender enum size is { sizeof(Gender) }");
            //Console.WriteLine($"int  Gender enum size is {sizeof(int)}");
            //we should consider changing the underlying type of an enum when memory efficiency matters,
            //when enum values are small, or when we need to match an external system or protocol.
            #endregion

            #region Problem8
            //Console.WriteLine($"Tempreture in Fehr is {Utility.ConvertTempreture(20,true)}");
            //Console.WriteLine($"Tempreture in Cel is {Utility.ConvertTempreture(20,false)}");
            ////A static class cannot have instance constructors because it cannot be instantiated.
            ////Only static members exist in a static class,
            ////and initialization is done via a static constructor if needed.
            #endregion

            #region Problem9
            //string[] arr = { "A", "B", "C", "X", "Z", "N" };
            //for(int i=0;i<arr.Length; i++)
            //{
            //    Grades g;
            //    bool can = Enum.TryParse<Grades>(arr[i], out g);
            //    Console.WriteLine(can?g.ToString():"Invalid Casting");
            //    //Enum.TryParse is safer than int.Parse because it does not throw exceptions on invalid input,
            //    //supports parsing enum names as well as numeric values,
            //    //and provides a cleaner and more reliable way to convert strings to enum types.
            //}
            #endregion

            #region Problem10
            //Employee[] employees =
            //{
            //    new Employee(5,"Youssef",50000),
            //    new Employee(6,"Mostafa",65021),
            //    new Employee(7,"Mohamed",22100),
            //    new Employee(7,"Amr",86521),

            //};
            //Employee target = new Employee(7, "Mohamed", 22100);
            //int idx=Helper<Employee>.SearchArray(employees, target);
            //Console.WriteLine(idx == -1 ? "Not found" : $"found At index {idx + 1}");
            ////In classes, both == and Equals() compare object references by default,
            ////but Equals() can be overridden for value comparison while == must be overloaded separately.
            ////In structs, Equals() performs value-based comparison by default,
            ////while == is not automatically supported unless explicitly overloaded.
            #endregion

            #region Problem11
            //Console.WriteLine($"max is {Helper<int>.Max(5, 10)}");
            //Console.WriteLine($"max is {Helper<int>.Max(20.2, 10.6)}");
            //Console.WriteLine($"max is {Helper<int>.Max("Youssef", "Sab3awy")}");
            ////Yes, generics in C# can be constrained using the where keyword.
            ////Constraints restrict the types that can be used as type parameters,
            ////ensuring type safety and allowing access to specific members of the constrained type.
            ////class Example<T>
            ////where T : class, IComparable<T>, new() //restriction to be both a class and implements the icomparable interface
            ////{
            ////        public T Create()
            ////        {
            ////            return new T();
            ////        }
            ////}
            #endregion

            #region Problem12
            //int[] arr = { 1, 2, 3, 4, 4, 4, 5 };
            //Helper<int>.ReplaceArray(arr, 4, 7);
            //foreach (int i in arr) Console.Write(i + " ");
            //Console.WriteLine();
            //string[] names = { "Youssef", "Mohamed", "Mostafa", "Amr" , "Youssef" };
            //Helper<string>.ReplaceArray(names, "Youssef", "Sab3awy");
            //foreach (string name in names) Console.Write(name + " ");
            ////A generic class has type parameters for the entire class and all its members,
            ////while a generic method has type parameters only for that method.
            ////Generic classes are used when the type affects the whole class,
            ////whereas generic methods are used for individual reusable methods that work with multiple types.
            #endregion

            #region Problem13
            //Rectangle_Stru r1 = new Rectangle_Stru(5, 3);
            //Rectangle_Stru r2 = new Rectangle_Stru(2, 9);
            //Console.WriteLine(r1.ToString());
            //Console.WriteLine(r2.ToString());
            //Helper<Rectangle_Stru>.SwapRectangle(ref r1,ref r2);
            //Console.WriteLine(r1.ToString());
            //Console.WriteLine(r2.ToString());
            ////Using a generic swap method is preferable because it eliminates code duplication,
            ////ensures type safety, works with any type (value or reference),
            ////and is easier to maintain compared to writing separate swap methods for each type.
            #endregion

            #region Peoblem14
            //Employee[] employees =
            //{
            //    new Employee(5,"Youssef",50000,1,"CS"),
            //    new Employee(6,"Mostafa",65021,2,"IT"),
            //    new Employee(7,"Mohamed",22100,3,"Cloud"),
            //    new Employee(7,"Amr",86521,4,"Ai"),

            //};
            //Employee target = new Employee(7, "Mohamed", 22100,3,"Cloud");
            //int idx = Helper<Employee>.SearchArray(employees, target);
            //Console.WriteLine(idx == -1 ? "Not found" : $"found At index {idx + 1}");
            ////Overriding Equals in the Department class allows comparisons based on the content (e.g., department name)
            ////rather than object references.
            ////This ensures that searches correctly identify all employees in the same department,
            ////even if different Department instances are used.
            #endregion

            #region Problem15
            //Circle c1 = new Circle(5, "Blue");
            //Circle c2 = new Circle(5, "Blue");
            //Console.WriteLine(c1.Equals(c2)); // true , value comparision
            ////Console.WriteLine(c2==c1); --> compilation error , should be overloaded

            //CircleC c3 = new CircleC(5, "Blue");
            //CircleC c4 = new CircleC(5, "Blue");

            //Console.WriteLine(c3.Equals(c4));
            //Console.WriteLine(c3 == c4); //both false , different ref
            //c4 = c3;
            //Console.WriteLine(c3.Equals(c4));
            //Console.WriteLine(c3 == c4); // both true , same ref
            ////== is not implemented by default for structs
            ////because the compiler cannot automatically determine what equality should mean for all structs
            ////(especially those containing nested value types or reference types).
            ////By default, Equals() does a field-by-field comparison,
            ////and if == is needed, it must be explicitly overloaded by the developer.
            #endregion

            /////Part02\\\\
            #region Problem1
            //int[] nums = { 1, 2, 3, 4, 5 };
            //Helper<int>.ReverseArray(nums);
            //foreach (int i in nums) Console.Write(i + " ");
            //Console.WriteLine();
            //string[] names = { "Youssef", "Mohamed", "Amr" };
            //Helper<string>.ReverseArray(names);
            //foreach (string i in names) Console.Write(i + " ");
            //Console.WriteLine();
            //Employee[] employees =
            //{
            //    new Employee(5,"Youssef",50000,1,"CS"),
            //    new Employee(6,"Mostafa",65021,2,"It"),
            //    new Employee(7,"Mohamed",22100,3,"Cloud"),
            //    new Employee(7,"Amr",86521,4,"Ai"),
            //};
            //Helper<Employee>.ReverseArray(employees);
            //foreach (Employee employee in employees) Console.WriteLine(employee.ToString());
            #endregion

            #region Problem2
            //Stack<int> intStack = new Stack<int>(5);
            //intStack.Push(10);
            //intStack.Push(20);
            //intStack.Push(30);

            //Console.WriteLine($"Integer stack peek {intStack.Peek()}"); // 30

            //Console.WriteLine($"Pop: {intStack.Pop()}");

            //Stack<string> strStack = new Stack<string>(3);
            //strStack.Push("Apple");
            //strStack.Push("Banana");

            //Console.WriteLine($"Integer stack peek {strStack.Peek()}"); // Banana
            #endregion

            #region Problem3
            //int[] nums = { 10, 20, 30, 40 };
            //Helper<int>.SwapInd(nums, 0, 2);
            //foreach (int i in nums) Console.Write(i + " ");
            //Console.WriteLine();

            //string[] names = { "Youssef", "Mohamed", "Amr" , "Mostafa" };
            //Helper<string>.SwapInd(names, 1, 3);
            //foreach (string name in names) Console.Write(name + " ");
            //Console.WriteLine();
            #endregion

            #region Problem4
            //int[] nums = { 10, 20, 30, 40 };
            //int maxi = Helper<int>.ArrayMax(nums);
            //Console.WriteLine($"Maximum is {maxi}");

            //string[] names = { "Youssef", "Mohamed", "Amr", "Mostafa" };
            //string maxi2= Helper<string>.ArrayMax(names);
            //Console.WriteLine($"Maximum is {maxi2}");
            #endregion
        }
    }
    #region Weekdays
    enum Weekdays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }
    #endregion

    #region Grades
    enum Grades : short
    {
        A, B, C, D, E, F = -1
    }
    #endregion

    #region Gender
    enum Gender : byte
    {
        M = 1, F
    }
    #endregion

}
