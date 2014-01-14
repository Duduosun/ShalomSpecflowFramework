using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomTestFramework.Training
{
//An abstract class can provide complete, default code and/or just the details that have to be overridden
//Often a base class is not intended to be instantiated and is provided solely for the purpose of providing an 
//outline for subclasses. Such a class is known as an abstract class. An abstract class cannot be instantiated as 
//an object and is only provided for the purpose of deriving subclasses.
//Abstract classes are useful when you need a class for the purpose of inheritance and polymorphism
    public abstract class ShalomAbstract
    {
        int AbstractInteger;
        string AbstractString;

        public void ShalomAbstractNoDetailMethod() { }
        public void ShalomAbstractParameter(int AbstractInteger, string AbstractString)
        {
            switch (AbstractString)
            {
                case "One":
                    break;

                case "Two":
                    break;

                default:
                    break;
            }

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("This is a multiple of 3");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("This is a multiple of 5");
                }
                else if ((i % 3 == 0) || (i % 5 == 0))
                {
                    Console.WriteLine("This is a multiple of 3 and 5");
                }
                else Console.WriteLine(Convert.ToString(i));
            }

            Enumerable.Range(0, 100);
            Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0);
            Enumerable.Range(0, 100).Where(n => n % 3 == 0);
            Enumerable.Range(0, 100).Where(n => n % 5 == 0);
        }
        public void CalculatePrimeNumbers()
        {
            IEnumerable<int> numbers = Enumerable.Range (0,100);
            IEnumerable<int> ThreeMultiple = numbers.Where(n => n % 3 == 0);
            IEnumerable<int> FiveMultiple = numbers.Where(n => n % 5 == 0);
            IEnumerable<int> ThreeNFiveMultiple = numbers.Where(n => n % 3 == 0 || n % 5 == 0);
            IEnumerable<int> NotMultiple = numbers.Where(n => n % 3 != 0 || n % 5 != 0);          
        }

        public void ShalomAbstractMethodOne()
        {
            AbstractInteger = 181213;
            Console.WriteLine(AbstractInteger + " ShalomAbstractMethodOne Method in ShalomAbstract Class");
        }

        public virtual void ShalomVirtualNoDetailMethod() { }

        public virtual void ShalomVirtualMethodOne()
        {
            AbstractString = "String from ShalomAbstract Class";
            Console.WriteLine(AbstractString + " Original ShalomVirtualMethodOne Method in ShalomAbstract Class");
        }

#region Shortcut
        //propa
        //public static int GetMyProperty(DependencyObject obj)
        //{
        //    return (int)obj.GetValue(MyPropertyProperty);
        //}

        //public static void SetMyProperty(DependencyObject obj, int value)
        //{
        //    obj.SetValue(MyPropertyProperty, value);
        //}

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty MyPropertyProperty =
        //    DependencyProperty.RegisterAttached("MyProperty", typeof(int), typeof(ownerclass), new PropertyMetadata(0));
       

        //propdp
        //public int MyPropertyPropdp
        //{
        //    get { return (int)GetValue(MyPropertyProperty); }
        //    set { SetValue(MyPropertyProperty, value); }
        //}

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty MyPropertyProperty =
        //    DependencyProperty.Register("MyProperty", typeof(int), typeof(ownerclass), new PropertyMetadata(0));

        
        //propg
        public int MyPropertyPropg { get; private set; }
#endregion
    }
}



//switch (i)
//{
//    case 30:
//        break;

//    case 50:
//        Console.WriteLine("This is a multiple of 3");
//        break;

//    case 70:
//        Console.WriteLine("This is a multiple of 3 and 5");
//        break;

//    default:
//        Console.WriteLine(Convert.ToString(AbstractInteger));
//        break;
//}

//Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0)