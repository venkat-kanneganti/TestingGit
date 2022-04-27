using System;

namespace DelegateEg
{
    class Program
    {
        //creating the delegates
        public delegate void AddNum(int a, int b);
        public delegate void SubNum(int x, int y);

        public void sum(int  a, int b)
        {
            Console.WriteLine("The sum is: {0}", a + b);
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("The sub is: {0}", x - y);
        }

        public static void Main(string[] args)
        {
            //creating object for class

            Program p = new Program();

            //creating object for delegate

            AddNum addNum = new AddNum(p.sum);
            SubNum subNum = new SubNum(p.sub);

            //passing the values to the delegate methods
            addNum(40, 30);
            subNum(60, 40);
        }
    }
}
