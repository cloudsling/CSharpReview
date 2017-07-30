using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.ExceptionTest
{
    class ExceptionTest
    {
        public void Test()
        {
            try
            {
                Exception1();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
        }

        private void Exception1()
        {
            try
            {
                Exception2();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Exception1 catch block...........");
                throw;
            }
            finally
            {
                Console.WriteLine("Exception1 finally block");
            }
        }
        private void Exception2()
        {
            try
            {
                Exception3();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Exception2 catch block...........");
                throw;
            }
            finally
            {
                Console.WriteLine("Exception2 finally block");
            }
        }
        private void Exception3()
        {
            try
            {
                throw new InvalidOperationException();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Exception3 catch block...........");
                throw;
            }
            finally
            {
                Console.WriteLine("Exception3 finally block");
            }
        }
    }
}
