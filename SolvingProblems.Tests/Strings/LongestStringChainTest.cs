using NUnit.Framework;
using SolvingProblems.Strings;

namespace SolvingProblems.Tests.Strings
{
    public class LongestStringChainTest
    {
        [Test]
        public void Test()
        {
            var service = new LongestStringChain();
            var words = new[]{ "a", "b", "ba", "bca", "bda", "bdca" };

            int result = service.LongestStrChain(words);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            var service = new LongestStringChain();
            var words = new[]{ "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" };

            int result = service.LongestStrChain(words);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Test3()
        {
            var service = new LongestStringChain();
            
            var words = new[]{ "a", "b", "ab", "bac" };

            int result = service.LongestStrChain(words);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test4()
        {
            var service = new LongestStringChain();
            var words = new[]
            {
                "ksqvsyq",
                "ks","kss","czvh",
                "zczpzvdhx","zczpzvh","zczpzvhx","zcpzvh","zczvh",
                "gr","grukmj","ksqvsq","gruj","kssq","ksqsq",
                "grukkmj","grukj","zczpzfvdhx","gru"
            };

            int result = service.LongestStrChain(words);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Test5()
        {
            var service = new LongestStringChain();
            var words = new[]
            {
                "bdca", "bda", "ca", "dca", "a"
            };

            int result = service.LongestStrChain(words);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Test6()
        {
            var service = new LongestStringChain();
            var words = new[]
            {
                "a", "b", "ba", "abc", "abd", "bdca"
            };

            int result = service.LongestStrChain(words);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Test7()
        {
            var service = new LongestStringChain();
            var words = new[]
            {
                "a", "ab", "ac", "bd", "abc", "abd", "abdd"
            };

            int result = service.LongestStrChain(words);
            Assert.That(result, Is.EqualTo(4));
        }
    }
}