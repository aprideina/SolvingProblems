using System.Threading;
using NUnit.Framework;

namespace SolvingProblems.Tests
{
    public class AwaitAndDisposeTest
    {
        [Test]
        public void Test()
        {
            var ds = new DisposableResource();

            var awaitAndDispose = new AwaitAndDispose(ds);
            var task = awaitAndDispose.GetLongingRunningTask();

            Thread.Sleep(20000);
            Assert.That(ds.Disposed, Is.EqualTo(false));
        }
    }
}