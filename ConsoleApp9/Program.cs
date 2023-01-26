using ConsoleApp9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace DelegatePractices
    {
    public class Program
    {
        static void Main1(string[] args)
        {
            Task9();

            Console.ReadLine();
        }
        public static void Task9()
        {
            // ctrl+k+d = document formatting

            Exception[] exceptions = new Exception[5];

            exceptions[0] = new CustomException("My Custom Exception");
            exceptions[1] = new FileNotFoundException();
            exceptions[2] = new TimeoutException();
            exceptions[3] = new DivideByZeroException(); // when divided to zero
            exceptions[4] = new InvalidOperationException();


            for (int i = 0; i < exceptions.Length; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {

                }
            }
        }

    }
}
