using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using SolvingProblems.Threading;

namespace SolvingProblems.Tests.Threading
{
    internal class PrintInOrderByCountTest
    {
        [Test]
        public void Test()
        {
            var results = new List<int>(6);
            var service = new PrintInOrderByCount(3);

            Task.Factory.StartNew(() => { service.Foo(() => results.Add(1)); });

            Task.Factory.StartNew(() => { service.Bar(() => results.Add(2)); });

            while (results.Count != 6)
            {
            }

            Assert.That(results[0], Is.EqualTo(1));
            Assert.That(results[1], Is.EqualTo(2));
            Assert.That(results[2], Is.EqualTo(1));
            Assert.That(results[3], Is.EqualTo(2));
            Assert.That(results[4], Is.EqualTo(1));
            Assert.That(results[5], Is.EqualTo(2));
        }
    }
}