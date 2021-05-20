using System;
using System.Threading;

namespace SolvingProblems.Threading
{
    public class PrintInOrderByCount
    {
        private readonly int n;
        private Semaphore firstSemaphore;
        private Semaphore secondSemaphore;
        private AutoResetEvent autoResetEvent;

        public PrintInOrderByCount(int n)
        {
            this.n = n;

            firstSemaphore = new Semaphore(0, 1);
            secondSemaphore = new Semaphore(1, 1);
            autoResetEvent = new AutoResetEvent(false);
        }

        public void Foo(Action printFoo)
        {
            for (var i = 0; i < n; i++)
            {
                secondSemaphore.WaitOne();
                printFoo();
                firstSemaphore.Release(1);

                if(i == 0)
                    autoResetEvent.Set();
            }
        }

        public void Bar(Action printBar)
        {
            autoResetEvent.WaitOne();

            for (var i = 0; i < n; i++)
            {
                firstSemaphore.WaitOne();
                printBar();
                secondSemaphore.Release(1);
            }
        }
    }
}