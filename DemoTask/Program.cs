using System.Text;
using System.Threading.Channels;

namespace DemoTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem01  
            //Console.Write("Entet Your String: ");
            //string input = Console.ReadLine();
            //Console.WriteLine($"Your String:{input}");
            //int n = int.Parse(input);
            //int n = Convert.ToInt32(input);
            //Console.WriteLine($"Your String After Convention:{n}");
            //using try and catch
            //try
            //{
            //    Console.Write("Entet Your String: ");
            //    string input = Console.ReadLine();
            //    Console.WriteLine($"Your String:{input}");
            //    //int n = int.Parse(input);
            //    int n = Convert.ToInt32(input);
            //    Console.WriteLine($"Your String After Convention:{n}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("string faill");
            //}
            //string input = null;

            //try
            //{
            //    int number1 = int.Parse(input);
            //    Console.WriteLine($"Parse: {number1}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Parse Exception: {ex.GetType().Name}");
            //}

            //try
            //{
            //    int number2 = Convert.ToInt32(input);
            //    Console.WriteLine($"Convert: {number2}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Convert Exception: {ex.GetType().Name}");
            //}

            //Question: What is the difference between int.Parse and Convert.ToInt32 when 
            //handling null inputs?
            // int.parse will throw an ArgumentNullException when input is null
            // Convert.ToInt32 will return 0 when input is null

            #endregion

            #region Problem02  
            //Console.Write("Enter Number: ");
            //int Number;
            //bool Flag = int.TryParse(Console.ReadLine(), out Number);
            //if (Flag)
            //{
            //    Console.WriteLine($"Your Number: {Number}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Number");
            //}

            //Question: Why is TryParse recommended over Parse in user-facing applications?
            //because TryParse not throw exception when number is invalid
            //Parse throw exception when number is invalid 
            #endregion

            #region Problem03   
            //object oObject;
            //oObject= "Mhmed";
            //Console.WriteLine($"String Get Hash Gode: {oObject.GetHashCode()}");

            //oObject = 'M';
            //Console.WriteLine($"Character Get Hash Gode: {oObject.GetHashCode()}");

            //oObject = 22;
            //Console.WriteLine($"Integer Get Hash Gode: {oObject.GetHashCode()}");

            //oObject = 3.14;
            //Console.WriteLine($"Double Get Hash Gode: {oObject.GetHashCode()}");

            //Question: Explain the real purpose of the GetHashCode() method. 
            //You can hash it, and I can use it in any hash collection. 
            #endregion

            #region Problem04 
            //Student s1 = new Student();
            //s1.Name = "Mhmed";
            //Student s2 = new Student();
            //s2.Name = "Malak";
            //Console.WriteLine($"s2 Before modification: {s2.Name}");
            //Console.WriteLine("-----------------------------------------");
            //s2 = s1;
            //Console.WriteLine($"s2 After modification: {s2.Name}");
            //s1.Name = "Hassan";
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine($"s2 After modification s1: {s2.Name}");

            // Question: What is the significance of reference equality in .NET? 
            //  helps you determine whether you have two different copies
            // of an object or two variables pointing to the same object. 
            #endregion

            #region Problem05 
            //string s = "Hi";
            //Console.WriteLine(s);
            //Console.WriteLine(s.GetHashCode());
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //s += "Willy";
            //Console.WriteLine(s);
            //Console.WriteLine(s.GetHashCode());

            //Question: Why string is immutable in C# ? 
            // because string cannot change old value,create new value in memory

            #endregion

            #region Problem06 
            //StringBuilder sb = new StringBuilder("HI");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            //sb.Append("Willy");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());

            //Question: How does StringBuilder address the inefficiencies of string concatenation? 
            //string in c# immutable , so when you concatenate strings, a new string is created in memory each time.
            // StringBuilder is mutable, so it can modify the existing string without creating a new one, which improves performance and reduces memory usage.

            //Question: Why is StringBuilder faster for large-scale string modifications? 
            //StringBuilder is faster for large-scale modifications
            //because it reduces the number of temporary string objects and memory allocations.

            #endregion

            #region Problem07  
            //Console.WriteLine("Enter 2 int numbers");
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine(num1 + " + " + num2 + " = " +(num1 + num2));
            //Console.WriteLine(string.Format("{0} + {1} = {2}",num1,num2,num1+num2));
            //Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //Question: Which string formatting method is most used and why? 
            //String Interpolation
            //because it is simple, readable 
            #endregion


            Console.ReadKey();  
        }
    }
    class Student
    {
        
        public string Name;
    }
}
