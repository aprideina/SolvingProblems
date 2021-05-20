using System;
using System.Threading;

namespace SolvingProblems.Threading
{
    public class PrintInOrder
    {
        private Semaphore secondStep;
        private Semaphore thirdStep;

        public PrintInOrder()
        {
            secondStep = new Semaphore(0, 1);
            thirdStep = new Semaphore(0, 1);
        }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            secondStep.Release(1);
        }

        public void Second(Action printSecond)
        {
            // printSecond() outputs "second". Do not change or remove this line.
            secondStep.WaitOne();
            printSecond();
            thirdStep.Release(1);
        }

        public void Third(Action printThird)
        {
            // printThird() outputs "third". Do not change or remove this line.
            thirdStep.WaitOne();
            printThird();
        }
    }
}
