using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using SolvingProblems.Threading;

namespace SolvingProblems.Tests.Threading
{
    public class PrintInOrderTest
    {
        [Test]
        public void Test()
        {
            var results = new List<int>(3);
            var service = new PrintInOrder();

            Task.Factory.StartNew(() =>
            {
                service.Third(() => results.Add(3));
            });

            Task.Factory.StartNew(() =>
            {
                service.Second(() => results.Add(2));
            });

            Task.Factory.StartNew(() =>
            {
                service.First(() => results.Add(1));
            });

            Thread.Sleep(3000);

            while (results.Count != 3) { }

            Assert.That(results[0], Is.EqualTo(1));
            Assert.That(results[1], Is.EqualTo(2));
            Assert.That(results[2], Is.EqualTo(3));
        }
    }
}