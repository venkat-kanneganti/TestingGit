using System;

namespace trycatch
{
    class Program
    {
        int result = 0;
        public void Division(int n1, int n2)
        {
            try
            {
                result = n1 / n2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            
            finally
            {
                Console.WriteLine("Result: {0}", result);
                
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Division(25, 0);
            p.Division(35, 5);
            Console.Read();
        }
    }
}
