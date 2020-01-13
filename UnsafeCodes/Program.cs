using System;

namespace UnsafeCodes
{
    //The statements marked as unsafe by using the keyword unsafe runs outside the control of Garbage Collector
    class Program
    {
        // Unsafe keyword can be used as a modifier to a class, method, property, and constructor etc
        public unsafe static void UnsafeMethod()
        {
            int x = 10;
            int y = 20;
            int* ptr1 = &x;
            int* ptr2 = &y;
            Console.WriteLine((int)ptr1);
            Console.WriteLine((int)ptr2);
            Console.WriteLine(*ptr1);
            Console.WriteLine(*ptr2);
        }

        public void SafeMethod()
        {
            //you can also declare a block unsafe
            unsafe
            {
                int x = 10;
                int y = 20;
                int* ptr1 = &x;
                int* ptr2 = &y;
                Console.WriteLine((int)ptr1);
                Console.WriteLine((int)ptr2);
                Console.WriteLine(*ptr1);
                Console.WriteLine(*ptr2);
            }
        }

        public unsafe void MyMethod()
        {
            int x = 50;
            int y = 30;
            int* sum = add(&x, &y);
            Console.WriteLine(*sum); //* is used to retrieve the value stored in a memory location/address
        }

        //pointers can be passed as arguments to a method
        public unsafe int* add(int* x, int* y)
        {
            int sum;
            sum = *x + *y;
            return &sum; //& is used to retrieve the memory address of a variable
    }
        static void Main(string[] args)
        {
            UnsafeMethod();
            Program p = new Program();
            p.SafeMethod();
            p.MyMethod();
        }
    }
}
